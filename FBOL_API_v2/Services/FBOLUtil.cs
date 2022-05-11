namespace FBOL_API_v2
{
    public  class FBOLUtil
    {
        public static string RemoveRootTag(string XML) 
        {
            return XML.Replace("<root>", "").Replace("</root>", "");
        }
    }
}
