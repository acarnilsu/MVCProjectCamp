using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ImageFileManager : IImageFileService
    {
        IImageFileDal _ımagefileDal;

        public ImageFileManager(IImageFileDal ımagefileDal)
        {
            _ımagefileDal = ımagefileDal;
        }

        public ImageFile GetByID(int id)
        {
            return _ımagefileDal.Get(x => x.ImageID == id);
        }

        public List<ImageFile> GetList()
        {
            return _ımagefileDal.List();
        }

        public void ImageFileAdd(ImageFile ımageFile)
        {
            _ımagefileDal.Insert(ımageFile);
        }

        public void ImageFileDelete(ImageFile ımageFile)
        {
            _ımagefileDal.Delete(ımageFile);
        }

        public void ImageFileUpdate(ImageFile ımageFile)
        {
            _ımagefileDal.Update(ımageFile);
        }
    }
}
