using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YT.CMS.Common
{
    public static class TreeView
    {
        public static string TreeViewJson(this List<TreeViewModel> data, string parentId = "0")
        {
            StringBuilder strJson = new StringBuilder();
            List<TreeViewModel> item = data.FindAll(t => t.ParentID == parentId);
            strJson.Append("[");
            if (item.Count > 0)
            {
                foreach (TreeViewModel entity in item)
                {
                    strJson.Append("{");
                    strJson.Append("\"id\":\"" + entity.ID + "\",");
                    strJson.Append("\"text\":\"" + entity.Text.Replace("&nbsp;", "") + "\",");
                    strJson.Append("\"value\":\"" + entity.Value + "\",");
                    if (entity.Title != null && !string.IsNullOrEmpty(entity.Title.Replace("&nbsp;", "")))
                    {
                        strJson.Append("\"title\":\"" + entity.Title.Replace("&nbsp;", "") + "\",");
                    }
                    if (entity.Img != null && !string.IsNullOrEmpty(entity.Img.Replace("&nbsp;", "")))
                    {
                        strJson.Append("\"img\":\"" + entity.Img.Replace("&nbsp;", "") + "\",");
                    }
                    if (entity.CheckState != null)
                    {
                        strJson.Append("\"checkstate\":" + entity.CheckState + ",");
                    }
                    if (entity.ParentID != null)
                    {
                        strJson.Append("\"parentnodes\":\"" + entity.ParentID + "\",");
                    }
                    strJson.Append("\"showcheck\":" + entity.ShowCheck.ToString().ToLower() + ",");
                    strJson.Append("\"isexpand\":" + entity.IsExpand.ToString().ToLower() + ",");
                    if (entity.Complete == true)
                    {
                        strJson.Append("\"complete\":" + entity.Complete.ToString().ToLower() + ",");
                    }
                    strJson.Append("\"hasChildren\":" + entity.HasChildren.ToString().ToLower() + ",");
                    strJson.Append("\"ChildNodes\":" + TreeViewJson(data, entity.ID) + "");
                    strJson.Append("},");
                }
                strJson = strJson.Remove(strJson.Length - 1, 1);
            }
            strJson.Append("]");
            return strJson.ToString();
        }
    }
}
