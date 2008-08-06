using System;
using System.Collections.Generic;
using System.Text;

using System.Net;
using System.Drawing;
using System.Drawing.Imaging;

namespace libcvacars
{
    public class DownloadImage
    {

        public enum Graphics
        {
            SFC_RADAR = 1,
            SFC_ANALYSIS = 2,
            AIRMETS_ALL = 3
        }
        Image image
        {
            get
            {
                return _image;
            }
            set { }
        }
        private static string[] imageUrls = new string[] {
            "http://aviationweather.gov/data/obs/radar/rcm_sm_tops.gif",
            "http://adds.aviationweather.gov/data/progs/hpc_sfc_analysis.gif",
            "http://adds.aviationweather.gov/data/airmets/airmets_ALL.gif",
        };
        private Image _image;
        private string url;
        public DownloadImage( string url )
        {
            this.url = url;
            download();
        }
        private void download()
        {
            WebResponse res;
            try
            {
                WebRequest req = WebRequest.Create( url );
                res = req.GetResponse();
            }
            catch ( Exception ex )
            {
                throw new Exception( "Error downloading " + url + "!", ex );
            }
            try
            {
                _image = Image.FromStream( res.GetResponseStream() );
            }
            catch ( Exception ex )
            {
                throw new Exception( "Error saving image to memory!", ex );
            }
        }
    }
}
