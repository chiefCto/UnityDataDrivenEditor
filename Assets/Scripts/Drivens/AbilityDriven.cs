﻿
using System;
using System.Collections.Generic;
using System.Text;

namespace DataDriven
{
    /// <summary>
    /// 技能驱动
    /// </summary>
    public class AbilityDriven : BaseDriven
    {
        /// <summary>
        /// icon
        /// </summary>
        public string Icon = string.Empty;
        /// <summary>
        /// 技能预加载资源
        /// </summary>
        public List<AbilityPrecache> precaches = new List<AbilityPrecache>();
        /// <summary>
        /// 技能事件
        /// </summary>
        public Dictionary<string, AbilityEvent> events = new Dictionary<string, AbilityEvent>();
        /// <summary>
        /// 技能修改器
        /// </summary>
        public Dictionary<string, AbilityModifier> modifiers = new Dictionary<string, AbilityModifier>();
        /// <summary>
        /// 添加技能事件
        /// </summary>
        /// <param name="eventName">事件名称</param>
        /// <param name="abilityEvent">事件</param>
        /// <returns>是否添加成功</returns>
        public bool AddEvent(string eventName, AbilityEvent abilityEvent)
        {
            if (events.ContainsKey(eventName))
                return false;
            events.Add(eventName, abilityEvent);
            return true;
        }
        /// <summary>
        /// 添加技能修改器
        /// </summary>
        /// <param name="modifierName">修改器名称</param>
        /// <param name="abilityModifier">修改器</param>
        /// <returns>是否添加成功</returns>
        public bool AddModifier(string modifierName, AbilityModifier abilityModifier) {
            if(modifiers.ContainsKey(modifierName))
                return false;
            modifiers.Add(modifierName, abilityModifier);
            return true;
        }
        /// <summary>
        /// 批量添加修改器
        /// </summary>
        /// <param name="modifies">批量修改器</param>
        public void AddModifiers(Dictionary<string, AbilityModifier> modifies)
        {
            foreach (var item in modifies) {
                modifiers.Add(item.Key, item.Value);
            }
        }
    }
    /// <summary>
    /// 技能预加载资源
    /// </summary>
    public class AbilityPrecache
    {

    }
    /// <summary>
    /// 技能事件
    /// </summary>
    public class AbilityEvent
    {
        public AbilityEvent(string aname) {
            Name = aname;
        }
        /// <summary>
        /// 事件名称
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// 行为
        /// </summary>
        public List<AbilityAction> Actions = new List<AbilityAction>();
        public bool AddAction(AbilityAction action) {
            Actions.Add(action);
            return true;
        }
    }
    /// <summary>
    /// 技能修改器
    /// </summary>
    public class AbilityModifier
    {
        /// <summary>
        /// 修改器名称
        /// </summary>
        public string Name = string.Empty;
        /// <summary>
        /// 技能事件
        /// </summary>
        public Dictionary<string, AbilityEvent> events = new Dictionary<string, AbilityEvent>();

        public AbilityModifier(string modifierName)
        {
            this.Name = modifierName;
        }

        public bool AddEvent(string _name, AbilityEvent abilityEvent)
        {
            if (events.ContainsKey(_name))
                return false;
            events.Add(_name, abilityEvent);
            return true;
        }
    }
    /// <summary>
    /// 技能行为
    /// </summary>
    public class AbilityAction {
        public AbilityAction() {
            Name = "AbilityAction";
        }
        /// <summary>
        /// 行为名称
        /// </summary>
        public string Name { get; set; }
#if UNITY_EDITOR
        public virtual void Draw(int tag)
        {
            
        }
        public virtual void WriteDetail(StringBuilder sb, string v)
        {
        }
#endif
    }
}
