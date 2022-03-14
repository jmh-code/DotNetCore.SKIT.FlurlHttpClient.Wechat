﻿using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/exmail/group/update 接口的请求。</para>
    /// </summary>
    public class CgibinExmailGroupUpdateRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class EmailList : CgibinExmailGroupCreateRequest.Types.EmailList
            {
            }

            public class EmailGroupList : CgibinExmailGroupCreateRequest.Types.EmailGroupList
            {
            }

            public class TagIdList : CgibinExmailGroupCreateRequest.Types.TagIdList
            {
            }

            public class DepartmentIdList : CgibinExmailGroupCreateRequest.Types.DepartmentIdList
            {
            }
        }

        /// <summary>
        /// 获取或设置邮件群组 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("groupid")]
        [System.Text.Json.Serialization.JsonPropertyName("groupid")]
        public string GroupId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置邮件群组名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("groupname")]
        [System.Text.Json.Serialization.JsonPropertyName("groupname")]
        public string? GroupName { get; set; }

        /// <summary>
        /// 获取或设置邮箱列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("email_list")]
        [System.Text.Json.Serialization.JsonPropertyName("email_list")]
        public Types.EmailList? EmailList { get; set; }

        /// <summary>
        /// 获取或设置邮箱群组列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("group_list")]
        [System.Text.Json.Serialization.JsonPropertyName("group_list")]
        public Types.EmailGroupList? EmailGroupList { get; set; }

        /// <summary>
        /// 获取或设置标签 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tag_list")]
        [System.Text.Json.Serialization.JsonPropertyName("tag_list")]
        public Types.TagIdList? TagIdList { get; set; }

        /// <summary>
        /// 获取或设置部门 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("department_list")]
        [System.Text.Json.Serialization.JsonPropertyName("department_list")]
        public Types.DepartmentIdList? DepartmentIdList { get; set; }

        /// <summary>
        /// 获取或设置使用权限。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("allow_type")]
        [System.Text.Json.Serialization.JsonPropertyName("allow_type")]
        public int? AllowType { get; set; }

        /// <summary>
        /// 获取或设置使用权限。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("allow_emaillist")]
        [System.Text.Json.Serialization.JsonPropertyName("allow_emaillist")]
        public Types.EmailList? AllowEmailList { get; set; }

        /// <summary>
        /// 获取或设置允许使用的标签 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("allow_taglist")]
        [System.Text.Json.Serialization.JsonPropertyName("allow_taglist")]
        public Types.TagIdList? AllowTagIdList { get; set; }

        /// <summary>
        /// 获取或设置允许使用的部门 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("allow_departmentlist")]
        [System.Text.Json.Serialization.JsonPropertyName("allow_departmentlist")]
        public Types.DepartmentIdList? AllowDepartmentIdList { get; set; }
    }
}
