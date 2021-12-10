class Chair
    {
        /// Private Variables
        private string type;   // type of the chair
        private double length, // length of the chair in centimeters 
                       width,  // width of the chair in centimeters 
                       height;   // height of the cahir in centimeters
 
        /// Constructor
        public Chair(string type, double length, double width, double height)
        {
            this.type = type;
            this.length = length;
            this.width = width;
            this.height = height;
        }

        /// Methods for returning properties of the objects
        public string GetChairType()    { return type;   }
        public double GetChairLength()  { return length; }
        public double GetChairWidth()   { return width;  }
        public double GetChairHeight()  { return height; }

        /// Method for printing data about objects
        public void PrintData(Chair c)
        {
            Console.WriteLine("Chair type of {0} has the length of {1}, the width of {2} and the height of {3}", 
                              c.GetChairType(), c.GetChairLength(), c.GetChairWidth(), c.GetChairHeight());
        }

        /// Method for calculating area of the chair
        public double Area(Chair c)
        {
            return (c.GetChairLength() * c.GetChairWidth());
        }
    }
