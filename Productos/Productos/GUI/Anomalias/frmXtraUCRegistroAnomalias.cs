using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using System.Data.SqlClient;
using System.Data.Sql;
using System.Configuration;
using TableDependency.Enums;
using TableDependency.EventArgs;
using TableDependency.SqlClient;

namespace CeramicaCarrillo.GUI.Anomalias
{
    public partial class frmXtraUCRegistroAnomalias : DevExpress.XtraEditors.XtraUserControl
    {
        public static Model.BDCarrilloEntities bdCarrillo = new Model.BDCarrilloEntities();
        SqlDependency sqlDepAnomalias;
        String conexion = "data source=bdcarrillo.chv5yv9jro37.us-east-2.rds.amazonaws.com;initial catalog=BDCarrillo;Persist Security Info=True;user id=sa;password=atomiclotus3";

        public frmXtraUCRegistroAnomalias()
        {
            InitializeComponent();

            VistaDatosX();
            //SqlDependency.Start(conexion);
            DependencySQL();
            //gridView1.EndGrouping += (sender, e) =>
            //{
            //    gridView1.ExpandGroupRow(-1);
            //};
        }

        private void VistaDatosX()
        {
            anomaliasTableAdapter.Fill(dsRegAnomalias.Anomalias);
            gridControl1.DataSource = anomaliasBindingSource;
        }

        public void DependencySQL()
        {
            //ConnectionStringSettings conexion = ConfigurationManager.ConnectionStrings["BDCarrilloEntities"];
            
            //String conexion = "data source=bdcarrillo.chv5yv9jro37.us-east-2.rds.amazonaws.com;initial catalog=BDCarrillo;Persist Security Info=True;user id=sa;password=atomiclotus3";
            SqlConnection con = new SqlConnection(conexion);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from [dbo].[Anomalias];", con);
            cmd.Notification = null;

            SqlDependency.Start(conexion);

            sqlDepAnomalias = new SqlDependency(cmd);

            //cmd.ExecuteNonQuery();

            sqlDepAnomalias.OnChange += (dep);
            
            //sqlDepAnomalias.OnError += (sender, e) =>
            //{
            //    throw e.Error;
            //};

            //sqlDepAnomalias.Start();
            //sqlDepAnomalias.AddCommandDependency(cmd);
        }

        private  void dep(object sender, SqlNotificationEventArgs e)
        {
            MessageBox.Show("Cambio");
            //sqlDepAnomalias.OnChange -= dep;
            //DependencySQL();

            //anomaliasTableAdapter.Fill(dsRegAnomalias.Anomalias);

            //gridControl1.DataSource = anomaliasBindingSource;
        }
    }
}