using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Xero.Api.Core.Model.Types
{
    [DataContract(Namespace = "")]
    public enum BusinessStructure
    {
        [EnumMember(Value = "CHARITY")]
        Charity,

        [EnumMember(Value = "COMPANY")]
        Company,

        [EnumMember(Value = "LOOK_THROUGH_COMPANY")]
        LookThroughCompany,

        [EnumMember(Value = "NOT_FOR_PROFIT")]
        NotForProfit,

        [EnumMember(Value = "PARTNERSHIP")]
        Partnership,

        [EnumMember(Value = "S_CORPORATION")]
        SCorporation,

        [EnumMember(Value = "SELF_MANAGED_SUPERANNUATION_FUND")]
        SelfManagedSuperannuationFund,

        [EnumMember(Value = "SUPERANNUATION_FUND")]
        SuperannuationFund,

        [EnumMember(Value = "TRUST")]
        Trust,

        [EnumMember(Value = "CLUB_OR_SOCIETY")]
        ClubOrSociety,

        [EnumMember(Value = "SOLE_TRADER")]
        SoleTrader,

        [EnumMember(Value = "PERSON")]
        Person,

        [EnumMember(Value = "LLC")]
        Llc,

        [EnumMember(Value = "OTHER")]
        Other,

        [EnumMember(Value = "MAORI_AUTHORITY")]
        MaoriAuthority
    }
}
