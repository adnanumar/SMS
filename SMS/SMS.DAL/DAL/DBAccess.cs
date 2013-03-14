
using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Microsoft.CSharp;


public class DBAccess
{
    #region "Local Variables"

private SqlCommand cmd = new SqlCommand();
    private string strConnectionString = "";
    private bool handleErrors = false;
    private string strLastError = "";
    //private SqlDataReader rdrResult;
    //private bool rdrHasRows = false;
    #endregion
    #region "Constructors"

    public DBAccess()
    {
        
        SqlConnection cnn =  new SqlConnection();

      //  cnn.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
        cnn.ConnectionString = "Data Source=ABURAFAY-PC;Initial Catalog=SMSWeb;Integrated Security=true";
        cmd.Connection = cnn;
        
        cmd.CommandType = CommandType.StoredProcedure;

    }
    #endregion
    #region "Public Properties"


    public string CommandText
    {
        get { return cmd.CommandText; }
        set
        {
            cmd.CommandText = value;
            cmd.Parameters.Clear();
        }
    }

    public SqlParameterCollection Parameters
    {
        get { return cmd.Parameters; }
    }

    public string ConnectionString
    {
        get { return strConnectionString; }
        set { strConnectionString = value; }
    }

    public bool HandleExceptions
    {
        get { return handleErrors; }
        set { handleErrors = value; }
    }

    public string LastError
    {
        get { return strLastError; }
    }

    public int TimeOut
    {
        get { return cmd.CommandTimeout; }
        set { cmd.CommandTimeout = value; }
    }

    public System.Data.CommandType CommandType
    {
        get { return cmd.CommandType; }
        set { cmd.CommandType = value; }
    }
    #endregion
    #region "Public Functions"
    #region "ExecuteReader"


    public SqlDataReader ExecuteReader()
    {
        SqlDataReader reader = null;
        try
        {
            this.Open();
            reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }
        catch (Exception ex)
        {
            if (handleErrors)
            {
                strLastError = ex.Message;
            }
            else
            {
                throw;
            }
        }
        return reader;
    }
    #endregion
    #region "ExecuteReader"
    public SqlDataReader ExecuteReaderIncreasedTimeout(string commandtext)
    {
        SqlDataReader reader = null;
        try
        {
            cmd.CommandText = commandtext;
            cmd.CommandTimeout = 9000;
            reader = this.ExecuteReader();
        }
        catch (Exception ex)
        {
            if ((handleErrors))
            {
                strLastError = ex.Message;
            }
            else
            {
                throw;
            }
        }
        return reader;
    }
    #endregion
    #region "ExecuteReader"
    public SqlDataReader ExecuteReader(string commandtext)
    {
        SqlDataReader reader = null;
        try
        {
            cmd.CommandText = commandtext;
            reader = this.ExecuteReader();
        }
        catch (Exception ex)
        {
            if ((handleErrors))
            {
                strLastError = ex.Message;
            }
            else
            {
                throw;
            }
        }
        return reader;
    }
    #endregion

    public SqlDataReader ExecuteSingleRowReader()
    {
        SqlDataReader reader = null;
        try
        {
            
            this.Open();
            reader = cmd.ExecuteReader(CommandBehavior.SingleRow | CommandBehavior.CloseConnection);
        }
        catch (Exception ex)
        {
            if (handleErrors)
            {
                strLastError = ex.Message;
            }
            else
            {
                throw;
            }
        }
        return reader;
    }

    public SqlDataReader ExecuteSingleRowReader(string commandtext)
    {
        SqlDataReader reader = null;
        try
        {
            cmd.CommandText = commandtext;
            reader = this.ExecuteSingleRowReader();
        }
        catch (Exception ex)
        {
            if ((handleErrors))
            {
                strLastError = ex.Message;
            }
            else
            {
                throw;
            }
        }
        return reader;
    }
    #region "ExecuteScalar"

    public object ExecuteScalar()
    {
        object obj = null;
        try
        {
            this.Open();
            obj = cmd.ExecuteScalar();
            this.Close();
        }
        catch (Exception ex)
        {
            if (handleErrors)
            {
                strLastError = ex.Message;
            }
            else
            {
                throw;
            }
        }
        return obj;
    }
    #endregion
    #region "ExecuteScalar"

    public object ExecuteScalar(string commandtext)
    {
        object obj = null;
        try
        {
            cmd.CommandText = commandtext;
            obj = this.ExecuteScalar();
        }
        catch (Exception ex)
        {
            if ((handleErrors))
            {
                strLastError = ex.Message;
            }
            else
            {
                throw;
            }
        }
        return obj;
    }
    #endregion
    #region "ExecuteNonQuery"

    public int ExecuteNonQuery()
    {
        int i = -1;
        try
        {
            this.Open();
            i = cmd.ExecuteNonQuery();
            this.Close();
        }
        catch (Exception ex)
        {
            if (handleErrors)
            {
                strLastError = ex.Message;
            }
            else
            {
                throw;
            }
        }
        return i;
    }
    #endregion
    #region "ExecuteNonQuery"

    public int ExecuteNonQuery(string commandtext)
    {
        int i = -1;
        try
        {
            cmd.CommandText = commandtext;
            i = this.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            if (handleErrors)
            {
                strLastError = ex.Message;
            }
            else
            {
                throw;
            }
        }
        return i;
    }
    #endregion
    #region "ExecuteDataSet"


    public DataSet ExecuteDataSet()
    {
        SqlDataAdapter da = null;
        DataSet ds = null;
        try
        {
            da = new SqlDataAdapter();
            da.SelectCommand = (SqlCommand)cmd;
            ds = new DataSet();
            da.Fill(ds);
        }
        catch (Exception ex)
        {
            if ((handleErrors))
            {
                strLastError = ex.Message;
            }
            else
            {
                throw;
            }
        }
        return ds;
    }
    #endregion
    #region "ExecuteDataSet"

    public DataSet ExecuteDataSet(string commandtext)
    {
        DataSet ds = null;
        try
        {
            cmd.CommandText = commandtext;
            ds = this.ExecuteDataSet();
        }
        catch (Exception ex)
        {
            if (handleErrors)
            {
                strLastError = ex.Message;
            }
            else
            {
                throw;
            }
        }
        return ds;
    }
    #endregion
    #region "ExecuteDataTable"

    public DataTable ExecuteDataTable()
    {
        SqlDataAdapter da = null;
        DataTable dt = null;
        try
        {
            da = new SqlDataAdapter();
            da.SelectCommand = (SqlCommand)cmd;
            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {
            if ((handleErrors))
            {
                strLastError = ex.Message;
            }
            else
            {
                throw;
            }
        }
        return dt;
    }
    #endregion
    #region "ExecuteDataTable"

    public DataTable ExecuteDataTable(string commandtext)
    {
        DataTable dt = null;
        try
        {
            cmd.CommandText = commandtext;
            dt = this.ExecuteDataTable();
        }
        catch (Exception ex)
        {
            if (handleErrors)
            {
                strLastError = ex.Message;
            }
            else
            {
                throw;
            }
        }
        return dt;
    }
    #endregion
    #endregion
    #region "Public Subs"
    #region "AddParameter"

    public void AddParameter(string paramname, ParameterDirection paramdirection)
    {
        SqlParameter param = new SqlParameter();
        param.ParameterName = paramname;
        param.Direction = paramdirection;
        cmd.Parameters.Add(param);
    }
    #endregion
    #region "AddParameter"

    public void AddParameter(string paramname, object paramvalue)
    {
        SqlParameter param = new SqlParameter(paramname, paramvalue);
        cmd.Parameters.Add(param);
    }
    #endregion
    #region "AddParameter"

    public void AddParameter(IDataParameter param)
    {
        cmd.Parameters.Add(param);
    }
    #endregion
    #region "AddParameter"
    public void AddParameter(string paramId, SqlDbType sqlType, int paramSize, ParameterDirection paramDirection, object paramvalue)
    {

        if (paramId == string.Empty)
        {
            throw new ArgumentOutOfRangeException("paramId");
        }

        SqlParameter newSqlParam = new SqlParameter();
        newSqlParam.ParameterName = paramId;
        newSqlParam.SqlDbType = sqlType;
        newSqlParam.Direction = paramDirection;

        if (paramSize > 0)
        {
            newSqlParam.Size = paramSize;
        }
        cmd.Parameters.Add(newSqlParam);

    }
    #endregion
    #region "Open"

    private void Open()
    {
        cmd.Connection.Open();
    }
    #endregion
    #region "Close"
    private void Close()
    {
        cmd.Connection.Close();
    }
    #endregion
    #region "Dispose"

    //public void Dispose()
    //{
    //    cmd.Dispose();
    //    if (rdrResult != null)
    //    {
    //        if (rdrResult.IsClosed == false)
    //        {
    //            rdrResult.Close();
    //        }
    //    }
    //}
    #endregion
    #endregion

}