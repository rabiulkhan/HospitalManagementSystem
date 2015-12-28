using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dataacress;

namespace validation
{
    public class doctorMT
    {
        private string _did = "";

        public string Did
        {
            get { return _did; }
            set { _did = value; }
        }
        private string _dname = "";

        public string Dname
        {
            get { return _dname; }
            set { _dname = value; }
        }
        private string _dsex = "";

        public string Dsex
        {
            get { return _dsex; }
            set { _dsex = value; }
        }
        private string _daddress = "";

        public string Daddress
        {
            get { return _daddress; }
            set { _daddress = value; }
        }
        private string _demail = "";

        public string Demail
        {
            get { return _demail; }
            set { _demail = value; }
        }
        private string _dphone = "";

        public string Dphone
        {
            get { return _dphone; }
            set { _dphone = value; }
        }
        private string _ddpt = "";

        public string Ddpt
        {
            get { return _ddpt; }
            set { _ddpt = value; }
        }
        private string _dqualification = "";

        public string Dqualification
        {
            get { return _dqualification; }
            set { _dqualification = value; }
        }



        public void SaveD()
        {
            sqldoctor obj = new sqldoctor();
            obj.InsertDoctor(_did,
                                _dname,
                                _dsex,
                                _daddress,
                                _demail,
                                _dphone,
                                _ddpt,
                                _dqualification);
        }

        public DataSet LoadDoctor()
        {
            sqldoctor obj = new sqldoctor();
            return obj.getDoctor();

        }

        public DataSet getDoctor()
        {
            throw new NotImplementedException();
        }

    }
}
