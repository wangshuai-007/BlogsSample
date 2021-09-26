using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wexman.Design;

namespace ExpandCollection
{
    public class Student
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public string Description {  get; set; }
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public CourseCollection ListCourses {  get; set; }

    }
    public class CourseCollection : List<Course>, ICustomTypeDescriptor
    {
        // Implementation of interface ICustomTypeDescriptor 
        #region ICustomTypeDescriptor impl 

        public String GetClassName()
        {
            return TypeDescriptor.GetClassName(this, true);
        }

        public AttributeCollection GetAttributes()
        {
            return TypeDescriptor.GetAttributes(this, true);
        }

        public String GetComponentName()
        {
            return TypeDescriptor.GetComponentName(this, true);
        }

        public TypeConverter GetConverter()
        {
            return TypeDescriptor.GetConverter(this, true);
        }

        public EventDescriptor GetDefaultEvent()
        {
            return TypeDescriptor.GetDefaultEvent(this, true);
        }

        public PropertyDescriptor GetDefaultProperty()
        {
            return TypeDescriptor.GetDefaultProperty(this, true);
        }

        public object GetEditor(Type editorBaseType)
        {
            return TypeDescriptor.GetEditor(this, editorBaseType, true);
        }

        public EventDescriptorCollection GetEvents(Attribute[] attributes)
        {
            return TypeDescriptor.GetEvents(this, attributes, true);
        }

        public EventDescriptorCollection GetEvents()
        {
            return TypeDescriptor.GetEvents(this, true);
        }

        public object GetPropertyOwner(PropertyDescriptor pd)
        {
            return this;
        }


        /// <summary>
        /// Called to get the properties of this type. Returns properties with certain
        /// attributes. this restriction is not implemented here.
        /// </summary>
        /// <param name="attributes"></param>
        /// <returns></returns>
        public PropertyDescriptorCollection GetProperties(Attribute[] attributes)
        {
            return GetProperties();
        }

        /// <summary>
        /// Called to get the properties of this type.
        /// </summary>
        /// <returns></returns>
        public PropertyDescriptorCollection GetProperties()
        {
            // Create a collection object to hold property descriptors
            PropertyDescriptorCollection pds = new PropertyDescriptorCollection(null);

            // Iterate the list of employees
            for (int i = 0; i < this.Count; i++)
            {
                // Create a property descriptor for the employee item and add to the property descriptor collection
                var pd = new CourseCollectionPropertyDescriptor(this, i);
                pds.Add(pd);
            }
            // return the property descriptor collection
            return pds;
        }

        #endregion
    }
    //[TypeConverter(typeof(ExpandableObjectConverter))]
    [TypeConverter(typeof(CourseConverter))]
    public class Course
    {
        public int Id { get; set; }
        public string Name {  get; set; }
        public string Description {  get; set; }
        [EditorAttribute(typeof(GenericDictionaryEditor<string,string>), typeof(System.Drawing.Design.UITypeEditor))]
        public Dictionary<string, string> DicClassRoomId_Name {  get; set; }

    }

    internal class CourseConverter:ExpandableObjectConverter
    {
        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            if (destinationType == typeof(string) && value is Course course)
            {
                return course.Name;
            }

            return base.ConvertTo(context, culture, value, destinationType);
        }
    }
}
