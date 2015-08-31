using DeploymentManager.Bases;
using DeploymentManager.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeploymentManager.DummyClient
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeDummyData();
            comboBox1.Items.AddRange(_dummyFileTypes.ToArray());
            comboBox2.Items.AddRange(_dummyDeploymentMethods.ToArray());
            _dummyDeployments.ForEach(d => lstDeploys.Items.Add(d));
        }

        List<Project> _dummyProjects = new List<Project>();
        List<Supplier> _dummySuppliers = new List<Supplier>();
        List<User> _dummyUsers = new List<User>();
        List<InternalTicket> _dummyTickets = new List<InternalTicket>();

        List<BaseDeploymentMethod> _dummyDeploymentMethods = new List<BaseDeploymentMethod>();
        List<FileType> _dummyFileTypes = new List<FileType>();

        List<Deployment> _dummyDeployments = new List<Deployment>();



        private void InitializeDummyData()
        {
            InitializeDummyProject();
            InitializeDummySuppliers();
            InitializeDummyUsers();
            InitializeDummyTickets();
            InitializeDummyDeployments();

            InitializeDummyFileTypes();
            InitializeDummyDeploymentMethods();


        }

        private void InitializeDummyDeployments()
        {
            Deployment deployment1 = new Deployment() { ReleaseId = "CR:0001" };
            Deployment deployment2 = new Deployment() { ReleaseId = "CR:0002" };
            for (int i = 0; i < _dummyTickets.Count - 1; i++)
            {
                if (i % 2 == 0)
                {
                    deployment1.InternalTickets.Add(_dummyTickets[i]);
                }
                else
                {
                    deployment2.InternalTickets.Add(_dummyTickets[i]);
                }
            }
            _dummyDeployments.Add(deployment1);
            _dummyDeployments.Add(deployment2);


        }

        private void InitializeDummyFileTypes()
        {
            _dummyFileTypes.Add(new FileType { Name = "Text File", Extension = "txt" });
            _dummyFileTypes.Add(new FileType { Name = "Sql Script", Extension = "sql" });
        }

        private void InitializeDummyDeploymentMethods()
        {
            string host = "127.0.0.1";
            string port = "21";

            _dummyDeploymentMethods.Add(new DeploymentMethods.Ftp { Name = "Server1", Host = host, Port = port, UserName = "user1", Password = "1234", Directory = "Folder1" });
            _dummyDeploymentMethods.Add(new DeploymentMethods.Ftp { Name = "Server2", Host = host, Port = port, UserName = "user2", Password = "1234", Directory = "Folder2" });
        }

        private void InitializeDummyTickets()
        {
            for (int i = 1; i < 4; i++)
            {
                InternalTicket internalTicket = new InternalTicket() { Name = "ICTNO:" + i.ToString() };
                for (int j = 0; j < (i % 3) + 1; j++)
                {
                    ExternalTicket externalTicket = new ExternalTicket() { Name = "ASYB-" + i.ToString() + j.ToString() };
                    externalTicket.Project = _dummyProjects.First(p => p.Name == "ASYB");
                    externalTicket.User = _dummyUsers.First(u => (u.Role & Roles.Developer) == Roles.Developer && u.Supplier.Name == "AGİTO");
                    externalTicket.InternalTicket = internalTicket;
                }
                _dummyTickets.Add(internalTicket);
            }
        }

        private void InitializeDummySuppliers()
        {
            _dummySuppliers.Add(new Supplier() { Name = "ASYA" });
            _dummySuppliers.Add(new Supplier() { Name = "AGİTO" });
        }

        private void InitializeDummyProject()
        {
            _dummyProjects.Add(new Project() { Name = "ASYB" });
            _dummyProjects.Add(new Project() { Name = "WebSitesi" });
        }

        private void InitializeDummyUsers()
        {
            _dummyUsers.Add(new User() { Name = "Hakan", Role = Roles.Developer, Supplier = _dummySuppliers.First(s => s.Name == "AGİTO") });
            _dummyUsers.Add(new User() { Name = "Nail", Role = Roles.ITManager, Supplier = _dummySuppliers.First(s => s.Name == "ASYA") });
            _dummyUsers.Add(new User() { Name = "Zafer", Role = Roles.DBA, Supplier = _dummySuppliers.First(s => s.Name == "ASYA") });
            _dummyUsers.Add(new User() { Name = "Yusuf Gökhan", Role = Roles.Analyst, Supplier = _dummySuppliers.First(s => s.Name == "ASYA") });
            _dummyUsers.Add(new User() { Name = "Tarık", Role = Roles.Analyst | Roles.Developer, Supplier = _dummySuppliers.First(s => s.Name == "ASYA") });
        }

        private void lstInternalTickets_SelectedIndexChanged(object sender, EventArgs e)
        {
            InternalTicket ticket = lstInternalTickets.SelectedItem as InternalTicket;
            lstExternalTickets.Items.Clear();
            if (ticket != null)
            {
                ticket.ExternalTickets.ForEach(t => lstExternalTickets.Items.Add(t));
            }
        }

        private void lstDeploys_SelectedIndexChanged(object sender, EventArgs e)
        {
            Deployment deploy = lstDeploys.SelectedItem as Deployment;
            lstInternalTickets.Items.Clear();
            if (deploy != null)
            {
                deploy.InternalTickets.ForEach(t => lstInternalTickets.Items.Add(t));
            }
        }

        private void lstSubjects_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Subject subject = lstSubjects.SelectedItem as Subject;
            if (subject != null)
            {
                textBox1.Text = subject.FileName;
                comboBox1.SelectedItem = subject.FileType;
                comboBox1.SelectedItem = subject.DeploymentMethod;
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Subject subject = new Subject();
            subject.FileName = textBox1.Text;
            subject.FileType = comboBox1.SelectedItem as FileType;
            subject.DeploymentMethod = comboBox2.SelectedItem as BaseDeploymentMethod;
            int index = lstSubjects.Items.Add(subject);

            ExternalTicket externalTicket = lstExternalTickets.SelectedItem as ExternalTicket;
            externalTicket.FilesToDeploy.Add(index, subject);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Subject subject = lstSubjects.SelectedItem as Subject;
            subject.FileName = textBox1.Text;
            subject.FileType = comboBox1.SelectedItem as FileType;
            subject.DeploymentMethod = comboBox2.SelectedItem as BaseDeploymentMethod;

            lstSubjects.Refresh();

        }

        private void btnExecuteDeploy_Click(object sender, EventArgs e)
        {
            try
            {
                Deployment d = lstDeploys.SelectedItem as Deployment;
                d.ExecuteDeploy();
            }
            catch (BussinessException bex)
            {
                MessageBox.Show("Bussiness Exception :" + bex.Message);
            }
            catch (DeploymentException dex)
            {
                MessageBox.Show("Deployment Exception :" + dex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Diğer Exception :" + ex.Message);
            }
        }

    }
}
