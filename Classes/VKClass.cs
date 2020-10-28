using VkNet;
using VkNet.Model;
using VkNet.Model.RequestParams;
using VkNet.Enums.Filters;
using System.Linq;

namespace VkListInfo.Classes {
    
    class VKClass {
        public static VKClass VK = new VKClass(new VkApi());
        VkApi vkAPI;

        public VKClass (VkApi vkApi) {
            this.vkAPI = vkApi;
        }

        public void Auth(string token) {
            vkAPI.Authorize(new ApiAuthParams {
                AccessToken = token
            });
        }

        public string UserName() {
            return vkAPI.Account.GetProfileInfo().FirstName;
        }

        public dynamic GetAccountInfo(long[] id) {
            var p = vkAPI.Users.Get(id, ProfileFields.All).ToList();
            if (p == null)
                return 0;

            return p;
        }

    }
}
