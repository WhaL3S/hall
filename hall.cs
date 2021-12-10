class Hall
    {
        /// Private variables
        private double lengthHall,  // length of the hall in centimeters
                       widthHall;  // width  of the hall in centimeters

        /// Constructor 
        public Hall(double lengthHall, double widthHall)
        {
            this.lengthHall = lengthHall;
            this.widthHall = widthHall;
        }

        /// Methods to return object's properties
        public double GetLengthHall() { return lengthHall; }
        public double GetWidthHall()  { return widthHall; }

        /// Methods to set new values to object's properties
        public void SetLengthHall(double lengthHall)
        {
            this.lengthHall = lengthHall;
        }
        public void SetWidthHall(double widthHall)
        {
            this.widthHall = widthHall;
        }
    }
