using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace PerfWebService
{
    /// <summary>
    /// Service1 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。
    // [System.Web.Script.Services.ScriptService]
    public class PerfService : System.Web.Services.WebService
    {

        [WebMethod]
        public string JITDetachSign(string certInfo, string srcStr)
        {
            string signResult = string.Empty;
           JITComVCTKLib.JITDSign sign = null;
            try
            {
                sign = new JITComVCTKLib.JITDSign();
                signResult = sign.DetachSign(certInfo, srcStr);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                if (sign != null)
                {
                    sign = null;
                }
            }

            return signResult;
        }
    }
}