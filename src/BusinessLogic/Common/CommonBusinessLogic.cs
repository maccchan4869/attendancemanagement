using DataAccess.Common;
using Model.Common;
using static Const.Const;

namespace BusinessLogic.Common
{
    public class CommonBusinessLogic
    {
        /// <summary>
        /// 共通
        /// </summary>
        private readonly CommonDataAccess comDac;

        #region コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public CommonBusinessLogic()
        {
            this.comDac = new CommonDataAccess();
        }
        #endregion

        /// <summary>
        /// ユーザー情報を登録
        /// </summary>
        /// <returns></returns>
        public void RegisterUserInfo(RegisterUserModel Model)
        {
            comDac.RegisterUserInfo(Model);
        }
    }
}