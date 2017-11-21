using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teknik.Entity.Entities;
using Teknik.Entity.IdentityModels;

namespace Teknik.BLL.Repository
{
    public class ArizaRepo : RepositoryBase<Ariza, int> { }
    public class ArizaBilgilendirmeRepo : RepositoryBase<ArizaBilgilendirme, int> { }
    public class FotografRepo : RepositoryBase<Fotograf, int> { }
    public class PcMarkaRepo : RepositoryBase<PcMarka, int> { }
    public class PcModelRepo : RepositoryBase<PcModel, int> { }
    public class AnketRepo : RepositoryBase<Anket, int> { }

    public class KullaniciRepo : RepositoryBase<ApplicationUser, Guid> { }

    public class RolRepo : RepositoryBase<ApplicationRole, Guid> { }
}
