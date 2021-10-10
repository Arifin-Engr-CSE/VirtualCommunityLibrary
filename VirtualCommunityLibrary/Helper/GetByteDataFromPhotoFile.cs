using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace VirtualCommunityLibrary.Helper
{
    public static class GetByteDataFromPhotoFile
    {
        public static byte[] ConvertToBytes(HttpPostedFileBase image)
        {
            byte[] imageBytes = null;
            BinaryReader reader = new BinaryReader(image.InputStream);
            imageBytes = reader.ReadBytes((int)image.ContentLength);
            return imageBytes;
        }
    }
}