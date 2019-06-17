using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace YT.CMS.Entity
{

	 	//YT_CMS_Logs
		public class YT_CMS_LogsEntity
	{
	
      	/// <summary>
		/// ID
        /// </summary>
        public  string ID
        {
            get; 
            set; 
        }        
		/// <summary>
		/// LogType
        /// </summary>
        public  string LogType
        {
            get; 
            set; 
        }        
		/// <summary>
		/// LogContent
        /// </summary>
        public  string LogContent
        {
            get; 
            set; 
        }        
		/// <summary>
		/// ActionName
        /// </summary>
        public  string ActionName
        {
            get; 
            set; 
        }        
		/// <summary>
		/// ContollerName
        /// </summary>
        public  string ContollerName
        {
            get; 
            set; 
        }        
		/// <summary>
		/// CreateTime
        /// </summary>
        public  DateTime? CreateTime
        {
            get; 
            set; 
        }        
		/// <summary>
		/// UpdateTime
        /// </summary>
        public  DateTime? UpdateTime
        {
            get; 
            set; 
        }        
		/// <summary>
		/// Remark
        /// </summary>
        public  string Remark
        {
            get; 
            set; 
        }        
		   
	}
}