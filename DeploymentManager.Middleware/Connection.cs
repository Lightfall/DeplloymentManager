//21th may of 2015 thursday 00:01, puskulcu.
//Database Connectivity

using System;
//using System.Collections.Generic;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace DB
{

  public abstract class Connection
  {
    /// <summary>
    /// 21th may of 2015 thursday 00:11
    /// DB.Connection.Open
    /// this is the common signature of connector method
    /// </summary>
    /// <param name="AHost">name or address of host</param>
    /// <param name="APort">port number of server</param>
    /// <param name="ADB">name of db</param>
    /// <param name="AUser">name of user</param>
    /// <param name="APassword">password of user</param>
    /// <param name="AErrorCode">application code of error if any occurs</param>
    /// <param name="AErrorMessage">application message of error if any occurs</param>
    public abstract void Open(
          string AHost,
          string APort,
          string ADB,
          string AUser,
          string APassword,
      out string AErrorCode,
      out string AErrorMessage);

    /// <summary>
    /// 21th may of 2015 thursday 00:20
    /// DB.Connection.Close
    /// close db connectio
    /// </summary>
    /// <param name="AErrorCode">application code of error if any occurs</param>
    /// <param name="AErrorMessage">application message of error if any occurs</param>
    public abstract void Disconnect(
      out string AErrorCode,
      out string AErrorMessage);
  }
}
