using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV
{
    class stackObj
    {
        private string state;
        private DataRowView row;

        public stackObj(string state, DataRowView row)
        {
            this.State = state;
            this.row = row;
        }

        public string State { get => state; set => state = value; }
        public DataRowView Row { get => row; set => row = value; }
    }
}
