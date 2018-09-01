using Prism.Ioc;
using RecalBoxPhoneControler.Business;
using RecalBoxPhoneControler.Business.Interface;
using RecalBoxPhoneControler.Data;
using RecalBoxPhoneControler.Data.Interface;

namespace RecalBoxPhoneControler.Boostraper
{
    public static class RegisterHelper
    {

        public static void Register(IContainerRegistry container)
        {
            container.Register<IGamePadBusiness, GamePadBusiness>();
            container.Register<IGamePadData, GamePadData>();
        }
    }
}
