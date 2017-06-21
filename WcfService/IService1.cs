using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        misDatos consultar(int id, string descripcion, int tipo, int tipoConsulta);

        [OperationContract]
        int insertar(int id, string descripcion, int tipo, int tipoConsulta);

        [OperationContract]
        int modificar(int id, string descripcion, int tipo, int tipoConsulta);

        [OperationContract]
        int eliminar(int id, string descripcion, int tipo, int tipoConsulta);

        [OperationContract]
        List<misDatos> mostrarTodos(int id, string descripcion, int tipo, int tipoConsulta);


    }

      //estos son los datos que retorna el sp
    [DataContract]

    public class misDatos
    {
        int id;
        string descripcion;
        int tipo;


        [DataMember]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        [DataMember]
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        [DataMember]
        public int Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
    }

    
}
