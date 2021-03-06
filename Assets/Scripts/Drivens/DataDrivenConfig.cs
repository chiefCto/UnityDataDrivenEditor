﻿namespace DataDriven
{
    /// <summary>
    /// 驱动编辑器的配置
    /// </summary>
    public class DataDrivenConfig
    {
        /// <summary>
        /// 驱动类型
        /// </summary>
        public enum DrivenType : int
        {
            BaseDriven,    // 基本驱动
            BuildDriven,   // 建筑驱动
            UnitDriven,    // 单位驱动
            CastDriven,    // 施法驱动
            ItemDriven,    // 物品驱动
            AbilityDriven,  // 技能驱动
        }
        /// <summary>
        /// 驱动中文名
        /// </summary>
        public static string[] DrivenTypeName = {
            "基本驱动",
            "建筑驱动",
            "单位驱动",
            "施法驱动",
            "物品驱动",
            "技能驱动",
        };
        /// <summary>
        /// 技能事件名称
        /// </summary>
        public enum AbilityEventName {
            OnSpellStart,
            OnProjecticleHit
        }
        /// <summary>
        /// 技能行为
        /// </summary>
        public enum AbilityActionName {
            RunScript,
            Damage,
            ApplyModifier,
            LinearProjectile
        }
        /// <summary>
        /// 技能行为描述
        /// </summary>
        public static string[] AbilityActionDes =
        {
            "执行脚本",
            "对目标造成伤害",
            "挂载修改器",
            "生成线性投射物"
        };
    }
}
