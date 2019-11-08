using asaigment.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asaigment.Service
{
    class GoogleDriveFileService: IFileService
    {
        public Task<bool> SaveMemberCredentialToFile(MemberCredential memberCredential)
    {
        throw new NotImplementedException();
    }

    public Task<MemberCredential> ReadMemberCredentialFromFile()
    {
        throw new NotImplementedException();
    }

    public void SignOutByDeleteToken()
    {
        throw new NotImplementedException();
    }
}
}
