using Kooboo.CMS.Common.Persistence.Non_Relational;
using Kooboo.CMS.Content.Models;
using UnidecodeSharpFork;

namespace syberside.Kooboo.CMS.Content.UserKeyGenerator.Unicode
{
    public class UserKeyGenerator : global::Kooboo.CMS.Content.Models.UserKeyGenerator
    {
        private const int MaxUserkeyLength = 256;

        public override string Generate(ContentBase content)
        {
            string userKey = content.UserKey;
            if (string.IsNullOrEmpty(userKey))
            {
                userKey = GetColumnValueForUserKey(content);
            }
            if (string.IsNullOrEmpty(userKey))
            {
                userKey = content.UUID;
            }
            else
            {
                string separator = content.GetRepository().AsActual().UserKeyHyphens;
                userKey = userKey.Unidecode();
                if (userKey.Length > MaxUserkeyLength)
                {
                    userKey = userKey.Substring(0, MaxUserkeyLength);
                }
                var tmpUserKey = EscapeUserKey(content, userKey);

                int tries = 0;
                while (IfUserKeyExists(content, tmpUserKey))
                {
                    tries++;
                    tmpUserKey = userKey + separator + tries.ToString();
                }
                userKey = tmpUserKey;
            }

            return userKey;
        }
    }
}