using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace battleships
{
    class Panel
    {
        private OccupationType OccupationType { get; set; }

        private Coordinates coordinates;

        internal Coordinates Coordinates { get => coordinates; set => coordinates = value; }

        public Panel(int row,int column)
        {
            coordinates = new Coordinates(row, column);
            OccupationType = OccupationType.Empty;
        }

        //public String Status
        //{
        //    get
        //    {
        //       // return OccupationType.GetAttributeDescription() ;
        //    }
        //}
    }
}
