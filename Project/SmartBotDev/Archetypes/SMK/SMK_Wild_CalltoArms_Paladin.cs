/*************************************************************************************
  * CLRVersion:          4.0.30319.42000
  * ClassName:           SMK_Wild_CalltoArmsPaladin
  * NameSpace:           SmartBotAPI.Plugins.API
  * CreateTime:          2021/4/8 15:34:18
  * ModifiedTime:        2021/4/8 15:34:18
  * Version:             1.0
  * HSVersion            20.0.0.77662
  * Description:         [狂野][贫瘠之地]号角骑
 *************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using SmartBot.Database;
using SmartBot.Plugins.API;

namespace SmartBotAPI.Plugins.API
{
    class SMK_Wild_CalltoArms_Paladin : Archetype
    {
        public List<Card.Cards> ArchetypeCardSet()
        {
            return new List<Card.Cards>()
            {
                Card.Cards.EX1_136,         //救赎 Redemption
                Card.Cards.DAL_570,         //永不屈服 Never Surrender!
                Card.Cards.DMF_236,         //古神在上 Oh My Yogg!
                Card.Cards.BAR_550,         //迅疾救兵 Galloping Savior
                Card.Cards.EX1_130,         //崇高牺牲 Noble Sacrifice
                Card.Cards.FP1_020,         //复仇 Avenge
                Card.Cards.BAR_880,         //定罪（等级1） Conviction (Rank 1)
                Card.Cards.ICC_038,         //正义保护者 Righteous Protector
                Card.Cards.BT_292,          //阿达尔之手 Hand of A'dal
                Card.Cards.FP1_017,         //尼鲁巴蛛网领主 Nerub'ar Weblord
                Card.Cards.GVG_058,         //护盾机器人 Shielded Minibot
                Card.Cards.YOP_031,         //螃蟹骑士 Crabrider
                Card.Cards.BAR_875,         //逝者之剑 Sword of the Fallen
                Card.Cards.EX1_349,         //神恩术 Divine Favor
                Card.Cards.DAL_573,         //指挥官蕾撒 Commander Rhyssa
                Card.Cards.BAR_890,         //十字路口大嘴巴 Crossroads Gossiper
                Card.Cards.LOOT_093,        //战斗号角 Call to Arms
                Card.Cards.CS2_092,         //王者祝福 Blessing of Kings
                Card.Cards.BAR_902,         //凯瑞尔·罗姆 Cariel Roame
            };
        }

        public string ArchetypeName()
        {
            return "SMK_Wild_CalltoArms_Paladin";
        }
    }
}
