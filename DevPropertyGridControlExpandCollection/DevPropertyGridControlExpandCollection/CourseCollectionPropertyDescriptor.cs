using System;
using System.ComponentModel;
using System.Text;

namespace ExpandCollection
{
    public class CourseCollectionPropertyDescriptor: PropertyDescriptor
    {
        private CourseCollection collection;
        private int index=-1;


        public CourseCollectionPropertyDescriptor(CourseCollection coll, int idx) :
            base("#" + idx.ToString(), null)
        {
            this.collection = coll;
            this.index = idx;
            collection[index].IndexName = "#" + idx.ToString();
        }

        public override AttributeCollection Attributes
        {
            get
            {
                return new AttributeCollection(null);
            }
        }

        public override bool CanResetValue(object component)
        {
            return true;
        }

        public override Type ComponentType
        {
            get
            {
                return this.collection.GetType();
            }
        }

        public override string DisplayName
        {
            get
            {
                Course course = this.collection[index];
                return course.Name;
            }
        }

        public override string Description
        {
            get
            {
                Course course = collection[index];
                StringBuilder sb = new StringBuilder();
                sb.Append(course.Name);

                return sb.ToString();
            }
        }

        public override object GetValue(object component)
        {
            return this.collection[index];
        }

        public override bool IsReadOnly
        {
            get { return true; }
        }

        public override string Name
        {
            get { return "#" + index.ToString(); }
        }

        public override Type PropertyType
        {
            get { return this.collection[index].GetType(); }
        }

        public override void ResetValue(object component)
        {
        }

        public override bool ShouldSerializeValue(object component)
        {
            return true;
        }

        public override void SetValue(object component, object value)
        {
            // this.collection[index] = value;
        }
    }
}