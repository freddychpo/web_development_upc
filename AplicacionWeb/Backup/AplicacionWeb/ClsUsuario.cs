using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace AplicacionWeb
{
    public class ClsUsuario: ClsConexion 
    {
        protected string Matricula, Contraseña;
        protected int IDUsuario;

        public ClsUsuario( string Matricula, string Contraseña)
        {
            this.Matricula = Matricula;
            this.Contraseña = Contraseña;
        }

        public int IDusuario
        {
            set { IDUsuario = value; }
            get { return IDUsuario; }
        }

        public string matricula
        {
            set { Matricula = value; }
            get { return Matricula; }
        }

        public string contraseña
        {
            set { Contraseña = value; }
            get { return Contraseña; }
        }

        public bool ConsultarUsuario()
        {
         DataTable DT = ConsultaDT("SELECT * FROM USUARIO " +
                    "WHERE MATRÍCULA = '" + Matricula  + "' AND CONTRASEÑA = '" + Contraseña + "'");
         if (DT.Rows.Count != 0)
         {
             return true;
         }
         else
         {
             return false;
         }
        }
    }

    
}