using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;

namespace itransition_project.Cloud
{
    public class ImageUploader
    {
        private CloudinaryDotNet.Cloudinary _cloudinary;

        public ImageUploader()
        {
            var account = new Account(
            "dee0sun8y",
            "544389232321383",
            "9YtSd3LzeVZZ3IXs_i0bA00mvwg");

            _cloudinary = new CloudinaryDotNet.Cloudinary(account);
        }

        public string UploadBase64Image(string base64Image)
        {
            var uploadParams = new ImageUploadParams
            {
                File = new FileDescription(base64Image)
            };
            var uploadResult = _cloudinary.Upload(uploadParams);
            return uploadResult.PublicId;
        }
    }
}