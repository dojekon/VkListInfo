using VkNet;
using VkNet.Model;
using VkNet.Model.RequestParams;

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

    }
}
