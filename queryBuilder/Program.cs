using System;

namespace queryBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            queryselect query = new queryselect();
            string selectquery = query.selectq().column1("id").column1("name").FROM().tableName("CUSTOMERS").WHERE().condition("name = 'Abdulrahman'").getquery();
            Console.Write(selectquery);
        }

        class queryselect
        {
            private string query;
            public queryselect()
            {
                this.query = "";
            }
            public queryselect selectq()
            {
                
                this.query += "SELECT ";
                return this;
            }
            public queryselect column1(string value)
            {
                
                this.query += value + " ";
                return this;
            }

            public queryselect FROM()
            {
                
                this.query += "FROM ";
                return this;

            }
            public queryselect tableName(string value)
            {
               
                this.query += value + " ";
                return this;
            }
            public queryselect WHERE()
            {
                
                this.query += "WHERE ";
                return this;
            }
            public queryselect condition(string value)
            {
                
                this.query += value;
                return this;
            }


            public string getquery()
            {
                return this.query;
            }
        }
    }
}
