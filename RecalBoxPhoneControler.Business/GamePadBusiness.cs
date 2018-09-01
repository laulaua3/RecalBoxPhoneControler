using RecalBoxPhoneControler.Business.Interface;
using RecalBoxPhoneControler.Data.Interface;

namespace RecalBoxPhoneControler.Business
{
    public class GamePadBusiness : IGamePadBusiness
    {
        readonly IGamePadData gamePad;
        public GamePadBusiness(IGamePadData gamePadData)
        {
            gamePad = gamePadData;
        }
    }
}
