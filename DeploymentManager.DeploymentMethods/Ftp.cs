using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeploymentManager.Bases;
using System.Net;
using System.IO;
using System.Reflection;


namespace DeploymentManager.DeploymentMethods
{
    public class Ftp : BaseDeploymentMethod
    {
        private const string keyHOST = "HOST";
        private const string keyPORT = "PORT";
        private const string keyUSER_NAME = "USER_NAME";
        private const string keyPASSWORD = "PASSWORD";
        private const string keyDIRECTORY = "DIRECTORY";



        public string Host
        {
            get
            {
                if (!Configuration.ContainsKey(keyHOST))
                {
                    Configuration.Add(keyHOST, "");
                }
                return Configuration[keyHOST];
            }
            set
            {
                if (!Configuration.ContainsKey(keyHOST))
                {
                    Configuration.Add(keyHOST, "");
                }
                Configuration[keyHOST] = value;
            }
        }
        public string Port
        {
            get
            {
                if (!Configuration.ContainsKey(keyPORT))
                {
                    Configuration.Add(keyPORT, "");
                }
                return Configuration[keyPORT];
            }
            set
            {
                if (!Configuration.ContainsKey(keyPORT))
                {
                    Configuration.Add(keyPORT, "");
                }
                Configuration[keyPORT] = value;
            }
        }
        public string UserName
        {
            get
            {
                if (!Configuration.ContainsKey(keyUSER_NAME))
                {
                    Configuration.Add(keyUSER_NAME, "");
                }
                return Configuration[keyUSER_NAME];
            }
            set
            {
                if (!Configuration.ContainsKey(keyUSER_NAME))
                {
                    Configuration.Add(keyUSER_NAME, "");
                }
                Configuration[keyUSER_NAME] = value;
            }
        }
        public string Password
        {
            get
            {
                if (!Configuration.ContainsKey(keyPASSWORD))
                {
                    Configuration.Add(keyPASSWORD, "");
                }
                return Configuration[keyPASSWORD];
            }
            set
            {
                if (!Configuration.ContainsKey(keyPASSWORD))
                {
                    Configuration.Add(keyPASSWORD, "");
                }
                Configuration[keyPASSWORD] = value;
            }
        }
        public string Directory
        {
            get
            {
                if (!Configuration.ContainsKey(keyDIRECTORY))
                {
                    Configuration.Add(keyDIRECTORY, "");
                }
                return Configuration[keyDIRECTORY];
            }
            set
            {
                if (!Configuration.ContainsKey(keyDIRECTORY))
                {
                    Configuration.Add(keyDIRECTORY, "");
                }
                Configuration[keyDIRECTORY] = value;
            }
        }



        public override void Deploy()
        {
            foreach (var item in Files)
            {
                Upload(item);
            }

        }

        private void Upload(string item)
        {
            try
            {

                string filename = item.Substring(item.LastIndexOf('\\')+1);
                // Get the object used to communicate with the server.
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://" + Host + "/" + Directory + "/" + filename);
                request.Method = WebRequestMethods.Ftp.UploadFile;

                // This example assumes the FTP site uses anonymous logon.
                request.Credentials = new NetworkCredential(UserName, Password);
                SetMethodRequiresCWD();
                using (Stream requestStream = request.GetRequestStream())
                {
                    using (FileStream fileStream = new FileStream(item, FileMode.Open))
                    {
                        fileStream.CopyTo(requestStream);
                    }
                }
                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                {
                    if (response.StatusCode != FtpStatusCode.FileActionOK && response.StatusCode!= FtpStatusCode.ClosingData)
                    {
                        throw new DeploymentException(response.StatusDescription);
                    }
                }
            }
            catch (DeploymentException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new DeploymentException(ex.Message, ex);
            }
        }

        private static void SetMethodRequiresCWD()
        {
            Type requestType = typeof(FtpWebRequest);
            FieldInfo methodInfoField = requestType.GetField("m_MethodInfo", BindingFlags.NonPublic | BindingFlags.Instance);
            Type methodInfoType = methodInfoField.FieldType;


            FieldInfo knownMethodsField = methodInfoType.GetField("KnownMethodInfo", BindingFlags.Static | BindingFlags.NonPublic);
            Array knownMethodsArray = (Array)knownMethodsField.GetValue(null);

            FieldInfo flagsField = methodInfoType.GetField("Flags", BindingFlags.NonPublic | BindingFlags.Instance);

            int MustChangeWorkingDirectoryToPath = 0x100;
            foreach (object knownMethod in knownMethodsArray)
            {
                int flags = (int)flagsField.GetValue(knownMethod);
                flags |= MustChangeWorkingDirectoryToPath;
                flagsField.SetValue(knownMethod, flags);
            }
        }

        public override string ToString()
        {
            return Name;
        }


    }
}
