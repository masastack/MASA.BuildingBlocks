// Copyright (c) MASA Stack All rights reserved.
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

namespace Masa.BuildingBlocks.Oidc.Models.Constans;

public static class StandardUserClaims
{
    [Description("subject 的缩写，唯一标识，一般为用户 ID")]
    public readonly static string Subject = "sub";
    [Description("姓名")]
    public readonly static string Name = "name";
    [Description("名字")]
    public readonly static string GivenName = "given_name";
    [Description("姓")]
    public readonly static string FamilyName = "family_name";
    [Description("中间名")]
    public readonly static string MiddleName = "middle_name";
    [Description("昵称")]
    public readonly static string NickName = "nickname";
    [Description("希望被称呼的名字")]
    public readonly static string PreferredUserName = "preferred_username";
    [Description("基础资料")]
    public readonly static string Profile = "profile";
    [Description("头像")]
    public readonly static string Picture = "picture";
    [Description("网站链接")]
    public readonly static string WebSite = "website";
    [Description("电子邮箱")]
    public readonly static string Email = "email";
    [Description("邮箱是否被认证")]
    public readonly static string EmailVerified = "email_verified";
    [Description("性别")]
    public readonly static string Gender = "gender";
    [Description("生日")]
    public readonly static string BirthDate = "birthdate";
    [Description("时区")]
    public readonly static string ZoneInfo = "zoneinfo";
    [Description("区域")]
    public readonly static string Locale = "locale";
    [Description("手机号")]
    public readonly static string PhoneNumber = "phone_number";
    [Description("认证手机号")]
    public readonly static string PhoneNumberVerified = "phone_number_verified";
    [Description("地址")]
    public readonly static string Address = "address";
    [Description("详细地址")]
    public readonly static string Formatted = "formatted";
    [Description("街道地址")]
    public readonly static string StreetAddress = "street_address";
    [Description("城市")]
    public readonly static string Locality = "locality";
    [Description("省")]
    public readonly static string Region = "region";
    [Description("邮编")]
    public readonly static string PostalCode = "postal_code";
    [Description("国家")]
    public readonly static string Country = "country";
    [Description("信息更新时间")]
    public readonly static string UpdatedAt = "updated_at";

    static Dictionary<string, string>? _claims;

    public static Dictionary<string, string> Claims => _claims ?? (_claims = GetClaims());

    static Dictionary<string, string> GetClaims()
    {
        var claims = new Dictionary<string, string>();
        var fileds = typeof(StandardUserClaims).GetFields(BindingFlags.Static | BindingFlags.Public);
        foreach (var filed in fileds)
        {
            var value = filed.GetValue(null)?.ToString() ?? "";
            var description = filed.GetCustomAttribute<DescriptionAttribute>()?.Description ?? "";
            claims.Add(value, description);
        }

        return claims;
    }
}
