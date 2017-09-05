using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reports.Models
{
   public class Enums
    {
    }
    /// <summary>
    /// 性别
    /// </summary>
    public enum Sex
    {
        /// <summary>
        /// 男性
        /// </summary>
        [Description("男性")]
        男 = 0,
        /// <summary>
        ///女性
        /// </summary>
        [Description("女性")]
        女 = 1,
    }
    public class SetSexItem : StringConverter
    {
        public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
        {
            return true;
        }

        public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
        {
            //@! 编辑下拉框中的items
            return new StandardValuesCollection(new string[] { "男", "女" });
        }
        //@! true: disable text editting.    false: enable text editting;
        public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
        {
            return true;
        }
    }
}
