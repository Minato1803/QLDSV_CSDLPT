using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    class UndoStack
    {
        private Stack<stackObj> stack;
        private string keyCol;
        private BindingSource bds;


        public UndoStack(string key, BindingSource tmp)
        {
            bds = tmp;
            stack = new Stack<stackObj>();
            keyCol = key;
        }


        public void PushUndo(string state, DataRowView row)
        {
            DataTable dt = row.Row.Table.Copy();
            switch (state){
                case "ADD":
                    {
                        int pos = bds.Find(keyCol, row[keyCol]);
                        stack.Push(new stackObj(state, dt.DefaultView[pos]));
                        break;
                    }
                case "ADJUST":
                    {
                        int pos = bds.Find(keyCol, row[keyCol]);
                        stack.Push(new stackObj(state, dt.DefaultView[pos]));
                        break;
                    }
                case "REMOVE":
                    {
                        int pos = bds.Find(keyCol, row[keyCol]);
                        stack.Push(new stackObj(state, dt.DefaultView[pos]));
                        break;
                    }
            }
        }

        public void Undo()
        {
            if(stack.Count > 0)
            {
                stackObj now = stack.Pop();
                switch (now.State)
                {
                    case "ADD":
                        {
                            // xóa sau khi thêm
                            int pos = bds.Find(keyCol, now.Row[keyCol]);
                            bds.RemoveAt(pos);
                            break;
                        }
                    case "ADJUST":
                        {
                            int pos = bds.Find(keyCol, now.Row[keyCol]);
                            for(int idx = 0; idx < now.Row.DataView.Table.Columns.Count; idx++)
                            {
                                string a = (string)((DataRowView)bds[pos])[idx];
                                string b = (string)now.Row[idx];
                                ((DataRowView)bds[pos])[idx] = now.Row[idx];
                                
                            }
                            break; 
                        }
                    case "REMOVE":
                        {
                            bds.Add(now.Row);
                            break;
                        }
                }
            }
        }

        public Boolean Empty()
        {
            return stack.Count == 0;
        }

    }
   
}
