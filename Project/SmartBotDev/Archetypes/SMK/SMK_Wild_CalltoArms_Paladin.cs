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
using SmartBotDevKit;

namespace SmartBotAPI.Plugins.API
{
    class SMK_Wild_CalltoArms_Paladin : Archetype
    {
        public List<Card.Cards> ArchetypeCardSet()
        {
            return new List<Card.Cards>()
            {
               (Card.Cards)CardHelper.Cards.救赎_EX1_136,
               (Card.Cards)CardHelper.Cards.永不屈服_DAL_570,
               (Card.Cards)CardHelper.Cards.古神在上_DMF_236,
               (Card.Cards)CardHelper.Cards.迅疾救兵_BAR_550,
               (Card.Cards)CardHelper.Cards.崇高牺牲_EX1_130,
               (Card.Cards)CardHelper.Cards.复仇_FP1_020,
               (Card.Cards)CardHelper.Cards.定罪_BAR_880,
               (Card.Cards)CardHelper.Cards.正义保护者_ICC_038,
               (Card.Cards)CardHelper.Cards.阿达尔之手_BT_292,
               (Card.Cards)CardHelper.Cards.尼鲁巴蛛网领主_FP1_017,
               (Card.Cards)CardHelper.Cards.护盾机器人_GVG_058,
               (Card.Cards)CardHelper.Cards.螃蟹骑士_YOP_031,
               (Card.Cards)CardHelper.Cards.逝者之剑_BAR_875,
               (Card.Cards)CardHelper.Cards.神恩术_EX1_349,
               (Card.Cards)CardHelper.Cards.指挥官蕾撒_DAL_573,
               (Card.Cards)CardHelper.Cards.十字路口大嘴巴_BAR_890,
               (Card.Cards)CardHelper.Cards.战斗号角_LOOT_093,
               (Card.Cards)CardHelper.Cards.王者祝福_CS2_092,
               (Card.Cards)CardHelper.Cards.凯瑞尔罗姆_BAR_902,
            };
        }

        public string ArchetypeName()
        {
            return "SMK_Wild_CalltoArms_Paladin";
        }
    }
}
