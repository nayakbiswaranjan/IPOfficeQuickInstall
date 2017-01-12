using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ipofficequickinstall
{
    public class PropertyFileHandler
    {
        private string[] AllProperties;
        public string[] SetProperties
        {
            get
            {
                return this.AllProperties;
            }
            set
            {
                this.AllProperties = value;
            }
        }
        public PropertyFileHandler()
        {

        }
        public PropertyFileHandler(string propertiesFilePath)
        {

        }
    }
}
