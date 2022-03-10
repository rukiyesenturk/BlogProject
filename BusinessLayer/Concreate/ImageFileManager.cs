using BusinessLayer.Abstruct;
using DataAccessLayer.Abstract;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concreate
{
    public class ImageFileManager : IImageFileService
    {
        IImageFileDal _ımageFileDal;
        public ImageFileManager(IImageFileDal ımageFileDal)
        {
            _ımageFileDal = ımageFileDal;
        }
        public List<ImageFile> GetList()
        {
            return _ımageFileDal.List();
        }
    }
}
