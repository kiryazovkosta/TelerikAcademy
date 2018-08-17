namespace _01.SchoolClasses
{
    using System;

    public class Note
    {
        private string comment;

        public Note()
            : this(null)
        {
        }

        public Note(string commentParam)
        {
            this.comment = commentParam;
        }

        public string Comment
        {
            get
            {
                return this.comment;
            }
            set
            {
                if (value != null 
                    && value.Length > 350)
                {
                    throw new ArgumentOutOfRangeException(nameof(this.comment));
                }

                this.comment = value;
            }
        }
    }
}
