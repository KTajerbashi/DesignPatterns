using DesignPatterns.Facade.SubSystem.DatabaseBackup;
using DesignPatterns.Facade.SubSystem.DrawContainer;
using DesignPatterns.Facade.SubSystem.EmailContainer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Facade.Pattern
{
    public interface IFacadContainer
    {
        IBackupRepository BackupRepository { get; }
        IEmailRepository EmailRepository { get; }
        IDrawRepository DrawRepository { get; }
    }
}
