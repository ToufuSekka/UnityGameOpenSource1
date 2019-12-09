using MySql.Data.MySqlClient;
using System.Collections;
using System.Collections.Generic;

public class SQLcom{
    static readonly string DATASERVER_NAME="";
    static readonly string DATASERVER_DATA = "";
    static readonly string DATASERVER_USER = "";
    static readonly string DATASERVER_PASS = "";

    MySqlConnection connenction = new MySqlConnection("Server="+DATASERVER_NAME
        +";Database="+ DATASERVER_DATA
        +";Uid="+ DATASERVER_USER
        + "Pwd"+ DATASERVER_PASS);
    MySqlCommand command = new MySqlCommand();

    
    void init() {
        //
    }

    void final() {
        //
    }
}
