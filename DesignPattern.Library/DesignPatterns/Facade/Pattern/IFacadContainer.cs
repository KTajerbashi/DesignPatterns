using DesignPatterns.Facade.Pattern.SubSystem.DatabaseBackup;
using DesignPatterns.Facade.Pattern.SubSystem.DrawContainer;
using DesignPatterns.Facade.Pattern.SubSystem.EmailContainer;
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
