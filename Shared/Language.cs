using System.IO;

public class GameLanguage
{
    //Client
    public static string PetMode_Both = "[宠物：进攻和移动]",
                         PetMode_MoveOnly = "[宠物：停止攻击]",
                         PetMode_AttackOnly = "[宠物：停止移动]",
                         PetMode_None = "[宠物：停止攻击或移动]",

                         AttackMode_Peace = "[模式：和平]",
                         AttackMode_Group = "[模式：组队]",
                         AttackMode_Guild = "[模式：行会]",
                         AttackMode_EnemyGuild = "[模式：敌对行会]",
                         AttackMode_RedBrown = "[模式：善恶]",
                         AttackMode_All = "[模式：全体攻击]",

                         LogOutTip = "您要返回角色选择界面吗？",
                         ExitTip = "您要退出游戏吗？",
                         DiedTip = "你已经死了，你想在城里复活吗？",
                         DropTip = "您确定要删除{0}吗？",

                         Inventory = "背包（{0}）",
                         Character = "任务（{0}）",
                         Skills = "技能（{0}）",
                         Quests = "任务 ({0})",
                         Options = "设置 ({0})",
                         Menu = "菜单",
                         GameShop = "游戏商城 ({0})",
                         BigMap = "大地图 ({0})",
                         DuraPanel = "Dura 面板",
                         Mail = "邮件",
                         Exit = "退出 ({0})",
                         LogOut = "登出 ({0})",
                         Help = "帮助 ({0})",
                         Keybinds = "快捷键",
                         Ranking = "排行榜 ({0})",
                         Creatures = "生物 ({0})",
                         Mount = "坐骑 ({0})",
                         Fishing = "钓鱼 ({0})",
                         Friends = "好友 ({0})",
                         Mentor = "师徒 ({0})",
                         Relationship = "关系 ({0})",
                         Groups = "组队 ({0})",
                         Guild = "行会 ({0})",
                         Expire = "过期: {0}",
                         ExpireNever = "过期：永不",
                         Never = "永不",
                         Trade = "交易 ({0})",
                         Size = "大小",
                         ChatSettings = "聊天设置",
                         Rotate = "旋转",
                         Close = "关闭 ({0})",
                         GameMaster = "游戏大师",

                         PatchErr = "无法获取补丁信息",
                         LastOnline = "最后在线",

                         Gold = "金币",
                         Credit = "信用",

                         YouGained = "您获得了{0}。",

                         YouGained2 = "您获得了 {0:###,###,###} {1}",

                         ExperienceGained = "获得经验值 {0}",

                         ItemDescription = "物品描述",
                         RequiredLevel = "要求等级 : {0}",
                         RequiredDC = "所需攻击 : {0}",
                         RequiredMC = "所需魔攻 : {0}",
                         RequiredSC = "所需道术 : {0}",
                         ClassRequired = "必修课 : {0}",

                         Holy = "神圣: + {0} (+{1})",
                         Holy2 = "神圣: + {0}",
                         Accuracy = "命中: + {0} (+{1})",
                         Accuracy2 = "命中: + {0}",
                         Agility = "敏捷: + {0} (+{1})",
                         Agility2 = "敏捷: + {0}",
                         DC = "攻击 + {0}~{1} (+{2})",
                         DC2 = "攻击 + {0}~{1}",
                         MC = "魔攻 + {0}~{1} (+{2})",
                         MC2 = "魔攻 + {0}~{1}",
                         SC = "道术 + {0}~{1} (+{2})",
                         SC2 = "道术 + {0}~{1}",
                         Durability = "耐久力",
                         Weight = "W:",
                         AC = "物防 + {0}~{1} (+{2})",
                         AC2 = "物防 + {0}~{1}",
                         MAC = "魔防 + {0}~{1} (+{2})",
                         MAC2 = "魔防 + {0}~{1}",
                         Luck = "幸运 + {0}",

                         DeleteCharacter = "您确定要删除角色{0}吗？",
                         CharacterDeleted = "您的角色已成功删除。",
                         CharacterCreated = "您的角色创建成功。",

                         Resolution = "分解",
                         Autostart = "自动启动",
                         Usrname = "用户名",
                         Password = "密  码",

                         ShuttingDown = "断开连接：服务器正在关闭。",
                         MaxCombine = "最大合并数：{0} {1} Shift +左键单击以拆分物品",
                         Count = " 数量 {0}",
                         ExtraSlots8 = "您确定要以1,000,000金币的价格购买8个额外的插槽吗？" +
                         "下次购买时，您可以解锁4个额外的插槽，最多40个插槽。",
                         ExtraSlots4 = "您确定要解锁4个额外的插槽吗？ 金币： {0:###,###}",

                         Chat_All = "全部",
                         Chat_Short = "喊话",
                         Chat_Whisper = "私聊",
                         Chat_Lover = "爱人",
                         Chat_Mentor = "师徒",
                         Chat_Group = "组队",
                         Chat_Guild = "行会",
                         ExpandedStorageLocked = "扩展存储锁定",
                         ExtraStorage = "您想以100万金币的价格租用10天的额外存储空间吗？",
                         ExtendYourRentalPeriod = "您想以100万金币的价格将租赁期延长10天吗？",

                         CannotLeaveGame = "{0}秒内无法离开游戏",
                         SelectKey = "Select the Key for: {0}",

                         WeaponSpiritFire = "你的武器被火焰之光照亮。",
                         SpiritsFireDisappeared = "火灵消失了。",
                         WeddingRing = "结婚戒指",
                         ItemTextFormat = "{0}{1}{2} {3}",
                         DropAmount = "掉落金额：",
                         LowMana = "没有足够的魔法来施放。",
                         NoCreatures = "您没有召唤任何生物。",
                         NoMount = "您没有拥有坐骑。",
                         NoFishingRod = "您没有拿着钓鱼竿。",
                         AttemptingConnect = "尝试连接到服务器。{0}尝试：{1}",

                         CreatingCharactersDisabled = "当前禁用创建新角色。",
                         InvalidCharacterName = "您的角色名称是不可接受的。",
                         NoClass = "您选择的职业不存在。 联系GM寻求帮助。",
                         ToManyCharacters = "您不能再创建{0}个角色。",
                         CharacterNameExists = "具有该名称的角色已经存在。",
                         WarriorsDes = "战士是一类强大的力量。 它们在战斗中不容易被杀死，并且具有能够使用的优势" +
                                        " 各种重型武器和盔甲。 因此，战士偏爱基于近战物理伤害的攻击。 他们的射程很弱" +
                                        " 攻击，但是专门为战士开发的各种设备弥补了他们在远程战斗中的劣势。",
                         WizardDes = "法师是一类低强度和耐力的人，但具有使用强大法术的能力。 他们的进攻法术非常有效，" +
                                        " 但由于施放这些咒语需要花费时间，因此它们很可能让自己对敌人的攻击持开放态度。" +
                                        " 因此，体弱的法师必须瞄准从安全距离攻击敌人。",
                         TaoistDes = "道士徒在天文学，医学以及除木公之外的其他学科中训练有素。 他们的专长在于直接帮助敌人，而不是直接与敌人交战。" +
                                        "道士可以召唤强大的生物，并且对魔法具有很高的抵抗力，并且是一类具有良好平衡的进攻和防御能力的阶级。",
                         AssassinDes = "刺客是一个秘密组织的成员，其历史相对未知。 他们能够隐藏自己并进行攻击，而别人却看不见它们，这自然使他们擅长快速杀死敌人。" +
                                        "他们有必要避免因生命力和力量薄弱而与多个敌人交战。",
                         ArcherDes = "弓箭手是一类极具准确性和力量的弓箭手，他们使用弓箭的强大技能来造成远距离伤害。" +
                                        "就像法师一样，他们倾向于敏锐的直觉来躲避即将来临的攻击，因为他们倾向于让自己面对正面攻击。" +
                                        "但是，他们强大的身体能力和致命的目标使他们能够将恐惧感灌输给所击中的任何人。",
                         DateSent = "发送日期 : {0}",
                         Send = "发送",
                         Reply = "回复",
                         Read = "读取",
                         Delete = "删除",
                         BlockList = "黑名单",
                         EnterMailToName = "请输入您想发邮件的人的名字。",
                         AddFriend = "添加",
                         RemoveFriend = "移除",
                         FriendMemo = "备忘录",
                         FriendMail = "邮件",
                         FriendWhisper = "私聊",
                         FriendEnterAddName = "请输入您要添加的人的姓名。",
                         FriendEnterBlockName = "请输入您要屏蔽的人的姓名。",
                         AddMentor = "添加师傅",
                         RemoveMentorMentee = "删除 师傅/徒弟",
                         MentorRequests = "允许/禁止 拜师（收徒）请求",
                         MentorEnterName = "请输入您想拜师的人的姓名。",
                         RestedBuff = "休息{0}将经验获取速度提高{1}％{2}",

                         ItemTypeWeapon = "武器",
                         ItemTypeArmour = "盔甲",
                         ItemTypeHelmet = "头盔",
                         ItemTypeNecklace = "项链",
                         ItemTypeBracelet = "手镯",
                         ItemTypeRing = "戒指",
                         ItemTypeAmulet = "护身符",
                         ItemTypeBelt = "腰带",
                         ItemTypeBoots = "靴子",
                         ItemTypeStone = "石头",
                         ItemTypeTorch = "火炬",
                         ItemTypePotion = "药水",
                         ItemTypeOre = "矿石",
                         ItemTypeMeat = "肉",
                         ItemTypeCraftingMaterial = "手工材料",
                         ItemTypeScroll = "卷轴",
                         ItemTypeGem = "宝石",
                         ItemTypeMount = "坐骑",
                         ItemTypeBook = "书",
                         ItemTypeScript = "脚本",
                         ItemTypeReins = "缰绳",
                         ItemTypeBells = "钟声",
                         ItemTypeSaddle = "马鞍",
                         ItemTypeRibbon = "缎带",
                         ItemTypeMask = "面具",
                         ItemTypeFood = "食物",
                         ItemTypeHook = "钩子",
                         ItemTypeFloat = "浮游物",
                         ItemTypeBait = "饵",
                         ItemTypeFinder = "发现者",
                         ItemTypeReel = "卷轴",
                         ItemTypeFish = "鱼",
                         ItemTypeQuest = "寻求",
                         ItemTypeAwakening = "唤醒",
                         ItemTypePets = "宠物",
                         ItemTypeTransform = "改造",
                         ItemTypeDeco = "装饰",

                         ItemGradeCommon = "普通",
                         ItemGradeRare = "稀有",
                         ItemGradeLegendary = "传奇",
                         ItemGradeMythical = "神话",
                         NoAccountID = "账户ID不存在。",
                         IncorrectPasswordAccountID = "错误的密码和账户ID组合。",
                         GroupSwitch = "允许/禁止 组队请求",
                         GroupAdd = "添加",
                         GroupRemove = "删除",
                         GroupAddEnterName = "请输入您要添加的人的姓名。",
                         GroupRemoveEnterName = "请输入您要删除的人的姓名。",
                         TooHeavyToHold = "太重了，无法保持。",
                         SwitchMarriage = "允许/禁止 结婚",
                         RequestMarriage = "求婚",
                         RequestDivorce = "要求离婚",
                         MailLover = "邮件 爱人",
                         WhisperLover = "私聊 爱人";

    //Server
    public static string Welcome = "欢迎来到{0}世界.",
                         OnlinePlayers = "在线玩家：{0}",
                         WeaponLuck = "运气停留在您的武器之内。",
                         WeaponCurse = "诅咒停留在你的武器之内。",
                         WeaponNoEffect = "没有效果。",
                         InventoryIncreased = "背包容量增加。",
                         FaceToTrade = "您必须面对某人进行交易。",
                         NoTownTeleport = "您不能在此处使用“城镇传送”",
                         CanNotRandom = "您不能在此处使用“随机传送”",
                         CanNotDungeon = "您不能在此处使用“地牢逃生”",
                         CannotResurrection = "活着时不能使用“复活卷轴”",
                         CanNotDrop = "您不能在此地图上丢弃物品",
                         NewMail = "新邮件到了。",
                         CouldNotFindPlayer = "找不到玩家{0}",
                         BeenPoisoned = "你中毒了",
                         AllowingMentorRequests = "您现在允许拜师请求。",
                         BlockingMentorRequests = "您现在正在阻止拜师请求。";

    //common
    public static string LowLevel = "您的级别不够高。",
                         LowGold = "金币不够。",
                         LevelUp = "恭喜你！ 您已经升级。 您的HP和MP已恢复。",
                         LowDC = "您没有足够的攻击。",
                         LowMC = "您没有足够的魔攻。",
                         LowSC = "您没有足够的道术。",
                         GameName = "吾爱传奇",
                         ExpandedStorageExpiresOn = "仓库扩展即将到期",

                         NotFemale = "你不是女性。",
                         NotMale = "你不是男性。",
                         NotInGuild = "你没有加入行会",
                         NoMentorship = "您目前没有要取消的师徒关系。",
                         NoBagSpace = "您没有足够的空间。";


    public static void LoadClientLanguage(string languageIniPath)
    {
        if (!File.Exists(languageIniPath))
        {
            SaveClientLanguage(languageIniPath);
            return;
        }

        InIReader reader = new InIReader(languageIniPath);
        GameLanguage.PetMode_Both = reader.ReadString("Language", "PetMode_Both", GameLanguage.PetMode_Both);
        GameLanguage.PetMode_MoveOnly = reader.ReadString("Language", "PetMode_MoveOnly", GameLanguage.PetMode_MoveOnly);
        GameLanguage.PetMode_AttackOnly = reader.ReadString("Language", "PetMode_AttackOnly", GameLanguage.PetMode_AttackOnly);
        GameLanguage.PetMode_None = reader.ReadString("Language", "PetMode_None", GameLanguage.PetMode_None);

        GameLanguage.AttackMode_Peace = reader.ReadString("Language", "AttackMode_Peace", GameLanguage.AttackMode_Peace);
        GameLanguage.AttackMode_Group = reader.ReadString("Language", "AttackMode_Group", GameLanguage.AttackMode_Group);
        GameLanguage.AttackMode_Guild = reader.ReadString("Language", "AttackMode_Guild", GameLanguage.AttackMode_Guild);
        GameLanguage.AttackMode_EnemyGuild = reader.ReadString("Language", "AttackMode_EnemyGuild", GameLanguage.AttackMode_EnemyGuild);
        GameLanguage.AttackMode_RedBrown = reader.ReadString("Language", "AttackMode_RedBrown", GameLanguage.AttackMode_RedBrown);
        GameLanguage.AttackMode_All = reader.ReadString("Language", "AttackMode_All", GameLanguage.AttackMode_All);

        GameLanguage.LogOutTip = reader.ReadString("Language", "LogOutTip", GameLanguage.LogOutTip);
        GameLanguage.ExitTip = reader.ReadString("Language", "ExitTip", GameLanguage.ExitTip);
        GameLanguage.DiedTip = reader.ReadString("Language", "DiedTip", GameLanguage.DiedTip);
        GameLanguage.DropTip = reader.ReadString("Language", "DropTip", GameLanguage.DropTip);

        GameLanguage.Inventory = reader.ReadString("Language", "Inventory", GameLanguage.Inventory);
        GameLanguage.Character = reader.ReadString("Language", "Character", GameLanguage.Character);
        GameLanguage.Skills = reader.ReadString("Language", "Skills", GameLanguage.Skills);
        GameLanguage.Quests = reader.ReadString("Language", "Quests", GameLanguage.Quests);
        GameLanguage.Options = reader.ReadString("Language", "Options", GameLanguage.Options);
        GameLanguage.Menu = reader.ReadString("Language", "Menu", GameLanguage.Menu);
        GameLanguage.GameShop = reader.ReadString("Language", "GameShop", GameLanguage.GameShop);
        GameLanguage.BigMap = reader.ReadString("Language", "BigMap", GameLanguage.BigMap);
        GameLanguage.DuraPanel = reader.ReadString("Language", "DuraPanel", GameLanguage.DuraPanel);
        GameLanguage.Mail = reader.ReadString("Language", "Mail", GameLanguage.Mail);
        GameLanguage.Exit = reader.ReadString("Language", "Exit", GameLanguage.Exit);
        GameLanguage.LogOut = reader.ReadString("Language", "LogOut", GameLanguage.LogOut);
        GameLanguage.Help = reader.ReadString("Language", "Help", GameLanguage.Help);
        GameLanguage.Keybinds = reader.ReadString("Language", "Keybinds", GameLanguage.Keybinds);
        GameLanguage.Ranking = reader.ReadString("Language", "Ranking", GameLanguage.Ranking);
        GameLanguage.Creatures = reader.ReadString("Language", "Creatures", GameLanguage.Creatures);
        GameLanguage.Mount = reader.ReadString("Language", "Mount", GameLanguage.Mount);
        GameLanguage.Fishing = reader.ReadString("Language", "Fishing", GameLanguage.Fishing);
        GameLanguage.Friends = reader.ReadString("Language", "Friends", GameLanguage.Friends);
        GameLanguage.Mentor = reader.ReadString("Language", "Mentor", GameLanguage.Mentor);
        GameLanguage.Relationship = reader.ReadString("Language", "Relationship", GameLanguage.Relationship);
        GameLanguage.Groups = reader.ReadString("Language", "Groups", GameLanguage.Groups);
        GameLanguage.Guild = reader.ReadString("Language", "Guild", GameLanguage.Guild);
        GameLanguage.Trade = reader.ReadString("Language", "Trade", GameLanguage.Trade);
        GameLanguage.Size = reader.ReadString("Language", "Size", GameLanguage.Size);
        GameLanguage.ChatSettings = reader.ReadString("Language", "ChatSettings", GameLanguage.ChatSettings);
        GameLanguage.Rotate = reader.ReadString("Language", "Rotate", GameLanguage.Rotate);
        GameLanguage.Close = reader.ReadString("Language", "Close", GameLanguage.Close);
        GameLanguage.GameMaster = reader.ReadString("Language", "GameMaster", GameLanguage.GameMaster);
        GameLanguage.Expire = reader.ReadString("Language", "Expire", GameLanguage.Expire);
        GameLanguage.ExpireNever = reader.ReadString("Language", "ExpireNever", GameLanguage.ExpireNever);
        GameLanguage.Never = reader.ReadString("Language", "Never", GameLanguage.Never);

        GameLanguage.PatchErr = reader.ReadString("Language", "PatchErr", GameLanguage.PatchErr);
        GameLanguage.LastOnline = reader.ReadString("Language", "LastOnline", GameLanguage.LastOnline);

        GameLanguage.LowLevel = reader.ReadString("Language", "LowLevel", GameLanguage.LowLevel);
        GameLanguage.LowGold = reader.ReadString("Language", "LowGold", GameLanguage.LowGold);
        GameLanguage.LowDC = reader.ReadString("Language", "LowDC", GameLanguage.LowDC);
        GameLanguage.LowMC = reader.ReadString("Language", "LowMC", GameLanguage.LowMC);
        GameLanguage.LowSC = reader.ReadString("Language", "LowSC", GameLanguage.LowSC);

        GameLanguage.Gold = reader.ReadString("Language", "Gold", GameLanguage.Gold);
        GameLanguage.Credit = reader.ReadString("Language", "Credit", GameLanguage.Credit);

        GameLanguage.YouGained = reader.ReadString("Language", "YouGained", GameLanguage.YouGained);
        GameLanguage.YouGained2 = reader.ReadString("Language", "YouGained2", GameLanguage.YouGained2);
        GameLanguage.ExperienceGained = reader.ReadString("Language", "ExperienceGained", GameLanguage.ExperienceGained);
        GameLanguage.LevelUp = reader.ReadString("Language", "LevelUp", GameLanguage.LevelUp);

        GameLanguage.ItemDescription = reader.ReadString("Language", "ItemDescription", GameLanguage.ItemDescription);
        GameLanguage.RequiredLevel = reader.ReadString("Language", "RequiredLevel", GameLanguage.RequiredLevel);
        GameLanguage.RequiredDC = reader.ReadString("Language", "RequiredDC", GameLanguage.RequiredDC);
        GameLanguage.RequiredMC = reader.ReadString("Language", "RequiredMC", GameLanguage.RequiredMC);
        GameLanguage.RequiredSC = reader.ReadString("Language", "RequiredSC", GameLanguage.RequiredSC);
        GameLanguage.ClassRequired = reader.ReadString("Language", "ClassRequired", GameLanguage.ClassRequired);
        GameLanguage.Holy = reader.ReadString("Language", "Holy", GameLanguage.Holy);
        GameLanguage.Holy2 = reader.ReadString("Language", "Holy2", GameLanguage.Holy2);
        GameLanguage.Accuracy = reader.ReadString("Language", "Accuracy", GameLanguage.Accuracy);
        GameLanguage.Accuracy2 = reader.ReadString("Language", "Accuracy2", GameLanguage.Accuracy2);
        GameLanguage.Agility = reader.ReadString("Language", "Agility", GameLanguage.Agility);
        GameLanguage.Agility2 = reader.ReadString("Language", "Agility2", GameLanguage.Agility2);
        GameLanguage.DC = reader.ReadString("Language", "DC", GameLanguage.DC);
        GameLanguage.DC2 = reader.ReadString("Language", "DC2", GameLanguage.DC2);
        GameLanguage.MC = reader.ReadString("Language", "MC", GameLanguage.MC);
        GameLanguage.MC2 = reader.ReadString("Language", "MC2", GameLanguage.MC2);
        GameLanguage.SC = reader.ReadString("Language", "SC", GameLanguage.SC);
        GameLanguage.SC2 = reader.ReadString("Language", "SC2", GameLanguage.SC2);
        GameLanguage.Durability = reader.ReadString("Language", "Durability", GameLanguage.Durability);
        GameLanguage.Weight = reader.ReadString("Language", "Weight", GameLanguage.Weight);
        GameLanguage.AC = reader.ReadString("Language", "AC", GameLanguage.AC);
        GameLanguage.AC2 = reader.ReadString("Language", "AC2", GameLanguage.AC2);
        GameLanguage.MAC = reader.ReadString("Language", "MAC", GameLanguage.MAC);
        GameLanguage.MAC2 = reader.ReadString("Language", "MAC2", GameLanguage.MAC2);
        GameLanguage.Luck = reader.ReadString("Language", "Luck", GameLanguage.Luck);

        GameLanguage.DeleteCharacter = reader.ReadString("Language", "DeleteCharacter", GameLanguage.DeleteCharacter);
        GameLanguage.CharacterDeleted = reader.ReadString("Language", "CharacterDeleted", GameLanguage.CharacterDeleted);
        GameLanguage.CharacterCreated = reader.ReadString("Language", "CharacterCreated", GameLanguage.CharacterCreated);

        GameLanguage.Resolution = reader.ReadString("Language", "Resolution", GameLanguage.Resolution);
        GameLanguage.Autostart = reader.ReadString("Language", "Autostart", GameLanguage.Autostart);
        GameLanguage.Usrname = reader.ReadString("Language", "Usrname", GameLanguage.Usrname);
        GameLanguage.Password = reader.ReadString("Language", "Password", GameLanguage.Password);

        GameLanguage.ShuttingDown = reader.ReadString("Language", "ShuttingDown", GameLanguage.ShuttingDown);

        GameLanguage.MaxCombine = reader.ReadString("Language", "MaxCombine", GameLanguage.MaxCombine);
        GameLanguage.Count = reader.ReadString("Language", "Count", GameLanguage.Count);
        GameLanguage.ExtraSlots8 = reader.ReadString("Language", "ExtraSlots8", GameLanguage.ExtraSlots8);
        GameLanguage.ExtraSlots4 = reader.ReadString("Language", "ExtraSlots4", GameLanguage.ExtraSlots4);

        GameLanguage.Chat_All = reader.ReadString("Language", "Chat_All", GameLanguage.Chat_All);
        GameLanguage.Chat_Short = reader.ReadString("Language", "Chat_Short", GameLanguage.Chat_Short);
        GameLanguage.Chat_Whisper = reader.ReadString("Language", "Chat_Whisper", GameLanguage.Chat_Whisper);
        GameLanguage.Chat_Lover = reader.ReadString("Language", "Chat_Lover", GameLanguage.Chat_Lover);
        GameLanguage.Chat_Mentor = reader.ReadString("Language", "Chat_Mentor", GameLanguage.Chat_Mentor);
        GameLanguage.Chat_Group = reader.ReadString("Language", "Chat_Group", GameLanguage.Chat_Group);
        GameLanguage.Chat_Guild = reader.ReadString("Language", "Chat_Guild", GameLanguage.Chat_Guild);
        GameLanguage.ExpandedStorageLocked = reader.ReadString("Language", "ExpandedStorageLocked", GameLanguage.ExpandedStorageLocked);
        GameLanguage.ExtraStorage = reader.ReadString("Language", "ExtraStorage", GameLanguage.ExtraStorage);
        GameLanguage.ExtendYourRentalPeriod = reader.ReadString("Language", "ExtendYourRentalPeriod", GameLanguage.ExtendYourRentalPeriod);
        GameLanguage.ExpandedStorageExpiresOn = reader.ReadString("Language", "ExpandedStorageExpiresOn", GameLanguage.ExpandedStorageExpiresOn);
        GameLanguage.GameName = reader.ReadString("Language", "GameName", GameLanguage.GameName);
        GameLanguage.CannotLeaveGame = reader.ReadString("Language", "CannotLeaveGame", GameLanguage.CannotLeaveGame);
        GameLanguage.SelectKey = reader.ReadString("Language", "SelectKey", GameLanguage.SelectKey);
        GameLanguage.WeaponSpiritFire = reader.ReadString("Language", "WeaponSpiritFire", GameLanguage.WeaponSpiritFire);
        GameLanguage.SpiritsFireDisappeared = reader.ReadString("Language", "SpiritsFireDisappeared", GameLanguage.SpiritsFireDisappeared);
        GameLanguage.WeddingRing = reader.ReadString("Language", "WeddingRing", GameLanguage.WeddingRing);
        GameLanguage.ItemTextFormat = reader.ReadString("Language", "ItemTextFormat", GameLanguage.ItemTextFormat);
        GameLanguage.DropAmount = reader.ReadString("Language", "DropAmount", GameLanguage.DropAmount);
        GameLanguage.LowMana = reader.ReadString("Language", "LowMana", GameLanguage.LowMana);

        GameLanguage.NotFemale = reader.ReadString("Language", "NotFemale", GameLanguage.NotFemale);
        GameLanguage.NotMale = reader.ReadString("Language", "NotMale", GameLanguage.NotMale);
        GameLanguage.NoCreatures = reader.ReadString("Language", "NoCreatures", GameLanguage.NoCreatures);
        GameLanguage.NoMount = reader.ReadString("Language", "NoMount", GameLanguage.NoMount);
        GameLanguage.NoFishingRod = reader.ReadString("Language", "NoFishingRod", GameLanguage.NoFishingRod);
        GameLanguage.NotInGuild = reader.ReadString("Language", "NotInGuild", GameLanguage.NotInGuild);
        GameLanguage.NoBagSpace = reader.ReadString("Language", "NoBagSpace", GameLanguage.NoBagSpace);
        GameLanguage.AttemptingConnect = reader.ReadString("Language", "AttemptingConnect", GameLanguage.AttemptingConnect);

        GameLanguage.CreatingCharactersDisabled = reader.ReadString("Language", "CreatingCharactersDisabled", GameLanguage.CreatingCharactersDisabled);
        GameLanguage.InvalidCharacterName = reader.ReadString("Language", "InvalidCharacterName", GameLanguage.InvalidCharacterName);
        GameLanguage.NoClass = reader.ReadString("Language", "NoClass", GameLanguage.NoClass);
        GameLanguage.ToManyCharacters = reader.ReadString("Language", "ToManyCharacters", GameLanguage.ToManyCharacters);
        GameLanguage.CharacterNameExists = reader.ReadString("Language", "CharacterNameExists", GameLanguage.CharacterNameExists);

        GameLanguage.WarriorsDes = reader.ReadString("Language", "WarriorsDes", GameLanguage.WarriorsDes);
        GameLanguage.WizardDes = reader.ReadString("Language", "WizardDes", GameLanguage.WizardDes);
        GameLanguage.TaoistDes = reader.ReadString("Language", "TaoistDes", GameLanguage.TaoistDes);
        GameLanguage.AssassinDes = reader.ReadString("Language", "AssassinDes", GameLanguage.AssassinDes);
        GameLanguage.ArcherDes = reader.ReadString("Language", "ArcherDes", GameLanguage.ArcherDes);

        GameLanguage.DateSent = reader.ReadString("Language", "DateSent", GameLanguage.DateSent);
        GameLanguage.Send = reader.ReadString("Language", "Send", GameLanguage.Send);
        GameLanguage.Reply = reader.ReadString("Language", "Reply", GameLanguage.Reply);
        GameLanguage.Read = reader.ReadString("Language", "Read", GameLanguage.Read);
        GameLanguage.Delete = reader.ReadString("Language", "Delete", GameLanguage.Delete);
        GameLanguage.BlockList = reader.ReadString("Language", "BlockList", GameLanguage.BlockList);
        GameLanguage.EnterMailToName = reader.ReadString("Language", "EnterMailToName", GameLanguage.EnterMailToName);
        GameLanguage.BeenPoisoned = reader.ReadString("Language", "BeenPoisoned", GameLanguage.BeenPoisoned);
        GameLanguage.AddFriend = reader.ReadString("Language", "AddFriend", GameLanguage.AddFriend);
        GameLanguage.RemoveFriend = reader.ReadString("Language", "RemoveFriend", GameLanguage.RemoveFriend);
        GameLanguage.FriendMemo = reader.ReadString("Language", "FriendMemo", GameLanguage.FriendMemo);
        GameLanguage.FriendMail = reader.ReadString("Language", "FriendMail", GameLanguage.FriendMail);
        GameLanguage.FriendWhisper = reader.ReadString("Language", "FriendWhisper", GameLanguage.FriendWhisper);
        GameLanguage.FriendEnterAddName = reader.ReadString("Language", "FriendEnterAddName", GameLanguage.FriendEnterAddName);
        GameLanguage.FriendEnterBlockName = reader.ReadString("Language", "FriendEnterBlockName", GameLanguage.FriendEnterBlockName);
        GameLanguage.AddMentor = reader.ReadString("Language", "AddMentor", GameLanguage.AddMentor);
        GameLanguage.RemoveMentorMentee = reader.ReadString("Language", "RemoveMentorMentee", GameLanguage.RemoveMentorMentee);
        GameLanguage.MentorRequests = reader.ReadString("Language", "MentorRequests", GameLanguage.MentorRequests);
        GameLanguage.MentorEnterName = reader.ReadString("Language", "MentorEnterName", GameLanguage.MentorEnterName);
        GameLanguage.NoMentorship = reader.ReadString("Language", "NoMentorship", GameLanguage.NoMentorship);
        GameLanguage.RestedBuff = reader.ReadString("Language", "RestedBuff", GameLanguage.RestedBuff);

        GameLanguage.ItemTypeWeapon = reader.ReadString("Language", "ItemTypeWeapon", GameLanguage.ItemTypeWeapon);
        GameLanguage.ItemTypeArmour = reader.ReadString("Language", "ItemTypeArmour", GameLanguage.ItemTypeArmour);
        GameLanguage.ItemTypeHelmet = reader.ReadString("Language", "ItemTypeHelmet", GameLanguage.ItemTypeHelmet);
        GameLanguage.ItemTypeNecklace = reader.ReadString("Language", "ItemTypeNecklace", GameLanguage.ItemTypeNecklace);
        GameLanguage.ItemTypeBracelet = reader.ReadString("Language", "ItemTypeBracelet", GameLanguage.ItemTypeBracelet);
        GameLanguage.ItemTypeRing = reader.ReadString("Language", "ItemTypeRing", GameLanguage.ItemTypeRing);
        GameLanguage.ItemTypeAmulet = reader.ReadString("Language", "ItemTypeAmulet", GameLanguage.ItemTypeAmulet);
        GameLanguage.ItemTypeBelt = reader.ReadString("Language", "ItemTypeBelt", GameLanguage.ItemTypeBelt);
        GameLanguage.ItemTypeBoots = reader.ReadString("Language", "ItemTypeBoots", GameLanguage.ItemTypeBoots);
        GameLanguage.ItemTypeStone = reader.ReadString("Language", "ItemTypeStone", GameLanguage.ItemTypeStone);
        GameLanguage.ItemTypeTorch = reader.ReadString("Language", "ItemTypeTorch", GameLanguage.ItemTypeTorch);
        GameLanguage.ItemTypePotion = reader.ReadString("Language", "ItemTypePotion", GameLanguage.ItemTypePotion);
        GameLanguage.ItemTypeOre = reader.ReadString("Language", "ItemTypeOre", GameLanguage.ItemTypeOre);
        GameLanguage.ItemTypeMeat = reader.ReadString("Language", "ItemTypeMeat", GameLanguage.ItemTypeMeat);
        GameLanguage.ItemTypeCraftingMaterial = reader.ReadString("Language", "ItemTypeCraftingMaterial", GameLanguage.ItemTypeCraftingMaterial);
        GameLanguage.ItemTypeScroll = reader.ReadString("Language", "ItemTypeScroll", GameLanguage.ItemTypeScroll);
        GameLanguage.ItemTypeGem = reader.ReadString("Language", "ItemTypeGem", GameLanguage.ItemTypeGem);
        GameLanguage.ItemTypeMount = reader.ReadString("Language", "ItemTypeMount", GameLanguage.ItemTypeMount);
        GameLanguage.ItemTypeBook = reader.ReadString("Language", "ItemTypeBook", GameLanguage.ItemTypeBook);
        GameLanguage.ItemTypeScript = reader.ReadString("Language", "ItemTypeScript", GameLanguage.ItemTypeScript);
        GameLanguage.ItemTypeReins = reader.ReadString("Language", "ItemTypeReins", GameLanguage.ItemTypeReins);
        GameLanguage.ItemTypeBells = reader.ReadString("Language", "ItemTypeBells", GameLanguage.ItemTypeBells);
        GameLanguage.ItemTypeSaddle = reader.ReadString("Language", "ItemTypeSaddle", GameLanguage.ItemTypeSaddle);
        GameLanguage.ItemTypeRibbon = reader.ReadString("Language", "ItemTypeRibbon", GameLanguage.ItemTypeRibbon);
        GameLanguage.ItemTypeMask = reader.ReadString("Language", "ItemTypeMask", GameLanguage.ItemTypeMask);
        GameLanguage.ItemTypeFood = reader.ReadString("Language", "ItemTypeFood", GameLanguage.ItemTypeFood);
        GameLanguage.ItemTypeHook = reader.ReadString("Language", "ItemTypeHook", GameLanguage.ItemTypeHook);
        GameLanguage.ItemTypeFloat = reader.ReadString("Language", "ItemTypeFloat", GameLanguage.ItemTypeFloat);
        GameLanguage.ItemTypeBait = reader.ReadString("Language", "ItemTypeBait", GameLanguage.ItemTypeBait);
        GameLanguage.ItemTypeFinder = reader.ReadString("Language", "ItemTypeFinder", GameLanguage.ItemTypeFinder);
        GameLanguage.ItemTypeReel = reader.ReadString("Language", "ItemTypeReel", GameLanguage.ItemTypeReel);
        GameLanguage.ItemTypeFish = reader.ReadString("Language", "ItemTypeFish", GameLanguage.ItemTypeFish);
        GameLanguage.ItemTypeQuest = reader.ReadString("Language", "ItemTypeQuest", GameLanguage.ItemTypeQuest);
        GameLanguage.ItemTypeAwakening = reader.ReadString("Language", "ItemTypeAwakening", GameLanguage.ItemTypeAwakening);
        GameLanguage.ItemTypePets = reader.ReadString("Language", "ItemTypePets", GameLanguage.ItemTypePets);
        GameLanguage.ItemTypeTransform = reader.ReadString("Language", "ItemTypeTransform", GameLanguage.ItemTypeTransform);

        GameLanguage.ItemGradeCommon = reader.ReadString("Language", "ItemGradeCommon", GameLanguage.ItemGradeCommon);
        GameLanguage.ItemGradeRare = reader.ReadString("Language", "ItemGradeRare", GameLanguage.ItemGradeRare);
        GameLanguage.ItemGradeLegendary = reader.ReadString("Language", "ItemGradeLegendary", GameLanguage.ItemGradeLegendary);
        GameLanguage.ItemGradeMythical = reader.ReadString("Language", "ItemGradeMythical", GameLanguage.ItemGradeMythical);

        GameLanguage.NoAccountID = reader.ReadString("Language", "NoAccountID", GameLanguage.NoAccountID);
        GameLanguage.IncorrectPasswordAccountID = reader.ReadString("Language", "IncorrectPasswordAccountID", GameLanguage.IncorrectPasswordAccountID);
        GameLanguage.GroupSwitch = reader.ReadString("Language", "GroupSwitch", GameLanguage.GroupSwitch);
        GameLanguage.GroupAdd = reader.ReadString("Language", "GroupAdd", GameLanguage.GroupAdd);
        GameLanguage.GroupRemove = reader.ReadString("Language", "GroupRemove", GameLanguage.GroupRemove);
        GameLanguage.GroupAddEnterName = reader.ReadString("Language", "GroupAddEnterName", GameLanguage.GroupAddEnterName);
        GameLanguage.GroupRemoveEnterName = reader.ReadString("Language", "GroupRemoveEnterName", GameLanguage.GroupRemoveEnterName);
        GameLanguage.TooHeavyToHold = reader.ReadString("Language", "TooHeavyToHold", GameLanguage.TooHeavyToHold);
        GameLanguage.SwitchMarriage = reader.ReadString("Language", "SwitchMarriage", GameLanguage.SwitchMarriage);
        GameLanguage.RequestMarriage = reader.ReadString("Language", "RequestMarriage", GameLanguage.RequestMarriage);
        GameLanguage.RequestDivorce = reader.ReadString("Language", "RequestDivorce", GameLanguage.RequestDivorce);
        GameLanguage.MailLover = reader.ReadString("Language", "MailLover", GameLanguage.MailLover);
        GameLanguage.WhisperLover = reader.ReadString("Language", "WhisperLover", GameLanguage.WhisperLover);
    }


    public static void SaveClientLanguage(string languageIniPath)
    {
        File.Delete(languageIniPath);
        InIReader reader = new InIReader(languageIniPath);
        reader.Write("Language", "PetMode_Both", GameLanguage.PetMode_Both);
        reader.Write("Language", "PetMode_MoveOnly", GameLanguage.PetMode_MoveOnly);
        reader.Write("Language", "PetMode_AttackOnly", GameLanguage.PetMode_AttackOnly);
        reader.Write("Language", "PetMode_None", GameLanguage.PetMode_None);

        reader.Write("Language", "AttackMode_Peace", GameLanguage.AttackMode_Peace);
        reader.Write("Language", "AttackMode_Group", GameLanguage.AttackMode_Group);
        reader.Write("Language", "AttackMode_Guild", GameLanguage.AttackMode_Guild);
        reader.Write("Language", "AttackMode_EnemyGuild", GameLanguage.AttackMode_EnemyGuild);
        reader.Write("Language", "AttackMode_RedBrown", GameLanguage.AttackMode_RedBrown);
        reader.Write("Language", "AttackMode_All", GameLanguage.AttackMode_All);

        reader.Write("Language", "LogOutTip", GameLanguage.LogOutTip);
        reader.Write("Language", "ExitTip", GameLanguage.ExitTip);
        reader.Write("Language", "DiedTip", GameLanguage.DiedTip);
        reader.Write("Language", "DropTip", GameLanguage.DropTip);

        reader.Write("Language", "Inventory", GameLanguage.Inventory);
        reader.Write("Language", "Character", GameLanguage.Character);
        reader.Write("Language", "Skills", GameLanguage.Skills);
        reader.Write("Language", "Quests", GameLanguage.Quests);
        reader.Write("Language", "Options", GameLanguage.Options);
        reader.Write("Language", "Menu", GameLanguage.Menu);
        reader.Write("Language", "GameShop", GameLanguage.GameShop);
        reader.Write("Language", "BigMap", GameLanguage.BigMap);
        reader.Write("Language", "DuraPanel", GameLanguage.DuraPanel);
        reader.Write("Language", "Mail", GameLanguage.Mail);
        reader.Write("Language", "Exit", GameLanguage.Exit);
        reader.Write("Language", "LogOut", GameLanguage.LogOut);
        reader.Write("Language", "Help", GameLanguage.Help);
        reader.Write("Language", "Keybinds", GameLanguage.Keybinds);
        reader.Write("Language", "Ranking", GameLanguage.Ranking);
        reader.Write("Language", "Creatures", GameLanguage.Creatures);
        reader.Write("Language", "Mount", GameLanguage.Mount);
        reader.Write("Language", "Fishing", GameLanguage.Fishing);
        reader.Write("Language", "Friends", GameLanguage.Friends);
        reader.Write("Language", "Mentor", GameLanguage.Mentor);
        reader.Write("Language", "Relationship", GameLanguage.Relationship);
        reader.Write("Language", "Groups", GameLanguage.Groups);
        reader.Write("Language", "Guild", GameLanguage.Guild);
        reader.Write("Language", "Trade", GameLanguage.Trade);
        reader.Write("Language", "Size", GameLanguage.Size);
        reader.Write("Language", "ChatSettings", GameLanguage.ChatSettings);
        reader.Write("Language", "Rotate", GameLanguage.Rotate);
        reader.Write("Language", "Close", GameLanguage.Close);
        reader.Write("Language", "GameMaster", GameLanguage.GameMaster);


        reader.Write("Language", "Expire", GameLanguage.Expire);
        reader.Write("Language", "ExpireNever", GameLanguage.ExpireNever);
        reader.Write("Language", "Never", GameLanguage.Never);
        reader.Write("Language", "PatchErr", GameLanguage.PatchErr);
        reader.Write("Language", "LastOnline", GameLanguage.LastOnline);

        reader.Write("Language", "LowLevel", GameLanguage.LowLevel);
        reader.Write("Language", "LowGold", GameLanguage.LowGold);
        reader.Write("Language", "LowDC", GameLanguage.LowDC);
        reader.Write("Language", "LowMC", GameLanguage.LowMC);
        reader.Write("Language", "LowSC", GameLanguage.LowSC);

        reader.Write("Language", "Gold", GameLanguage.Gold);
        reader.Write("Language", "Credit", GameLanguage.Credit);

        reader.Write("Language", "YouGained", GameLanguage.YouGained);
        reader.Write("Language", "YouGained2", GameLanguage.YouGained2);
        reader.Write("Language", "ExperienceGained", GameLanguage.ExperienceGained);
        reader.Write("Language", "LevelUp", GameLanguage.LevelUp);

        reader.Write("Language", "ItemDescription", GameLanguage.ItemDescription);
        reader.Write("Language", "RequiredLevel", GameLanguage.RequiredLevel);
        reader.Write("Language", "RequiredDC", GameLanguage.RequiredDC);
        reader.Write("Language", "RequiredMC", GameLanguage.RequiredMC);
        reader.Write("Language", "RequiredSC", GameLanguage.RequiredSC);
        reader.Write("Language", "ClassRequired", GameLanguage.ClassRequired);
        reader.Write("Language", "Holy", GameLanguage.Holy);
        reader.Write("Language", "Accuracy", GameLanguage.Accuracy);
        reader.Write("Language", "Agility", GameLanguage.Agility);
        reader.Write("Language", "DC", GameLanguage.DC);
        reader.Write("Language", "MC", GameLanguage.MC);
        reader.Write("Language", "SC", GameLanguage.SC);
        reader.Write("Language", "Durability", GameLanguage.Durability);
        reader.Write("Language", "Weight", GameLanguage.Weight);
        reader.Write("Language", "AC", GameLanguage.AC);
        reader.Write("Language", "MAC", GameLanguage.MAC);
        reader.Write("Language", "Luck", GameLanguage.Luck);

        reader.Write("Language", "DeleteCharacter", GameLanguage.DeleteCharacter);
        reader.Write("Language", "CharacterDeleted", GameLanguage.CharacterDeleted);
        reader.Write("Language", "CharacterCreated", GameLanguage.CharacterCreated);

        reader.Write("Language", "Resolution", GameLanguage.Resolution);
        reader.Write("Language", "Autostart", GameLanguage.Autostart);
        reader.Write("Language", "Usrname", GameLanguage.Usrname);
        reader.Write("Language", "Password", GameLanguage.Password);

        reader.Write("Language", "ShuttingDown", GameLanguage.ShuttingDown);

        reader.Write("Language", "MaxCombine", GameLanguage.MaxCombine);
        reader.Write("Language", "Count", GameLanguage.Count);
        reader.Write("Language", "ExtraSlots8", GameLanguage.ExtraSlots8);
        reader.Write("Language", "ExtraSlots4", GameLanguage.ExtraSlots4);

        reader.Write("Language", "Chat_All", GameLanguage.Chat_All);
        reader.Write("Language", "Chat_Short", GameLanguage.Chat_Short);
        reader.Write("Language", "Chat_Whisper", GameLanguage.Chat_Whisper);
        reader.Write("Language", "Chat_Lover", GameLanguage.Chat_Lover);
        reader.Write("Language", "Chat_Mentor", GameLanguage.Chat_Mentor);
        reader.Write("Language", "Chat_Group", GameLanguage.Chat_Group);
        reader.Write("Language", "Chat_Guild", GameLanguage.Chat_Guild);
        reader.Write("Language", "ExpandedStorageLocked", GameLanguage.ExpandedStorageLocked);
        reader.Write("Language", "ExtraStorage", GameLanguage.ExtraStorage);
        reader.Write("Language", "ExtendYourRentalPeriod", GameLanguage.ExtendYourRentalPeriod);
        reader.Write("Language", "ExpandedStorageExpiresOn", GameLanguage.ExpandedStorageExpiresOn);
        reader.Write("Language", "GameName", GameLanguage.GameName);
        reader.Write("Language", "CannotLeaveGame", GameLanguage.CannotLeaveGame);
        reader.Write("Language", "SelectKey", GameLanguage.SelectKey);
        reader.Write("Language", "WeaponSpiritFire", GameLanguage.WeaponSpiritFire);
        reader.Write("Language", "SpiritsFireDisappeared", GameLanguage.SpiritsFireDisappeared);
        reader.Write("Language", "WeddingRing", GameLanguage.WeddingRing);
        reader.Write("Language", "ItemTextFormat", GameLanguage.ItemTextFormat);
        reader.Write("Language", "DropAmount", GameLanguage.DropAmount);
        reader.Write("Language", "LowMana", GameLanguage.LowMana);

        reader.Write("Language", "NotFemale", GameLanguage.NotFemale);
        reader.Write("Language", "NotMale", GameLanguage.NotMale);
        reader.Write("Language", "NoCreatures", GameLanguage.NoCreatures);
        reader.Write("Language", "NoMount", GameLanguage.NoMount);
        reader.Write("Language", "NoFishingRod", GameLanguage.NoFishingRod);
        reader.Write("Language", "NotInGuild", GameLanguage.NotInGuild);
        reader.Write("Language", "AttemptingConnect", GameLanguage.AttemptingConnect);
        reader.Write("Language", "NoBagSpace", GameLanguage.NoBagSpace);

        reader.Write("Language", "CreatingCharactersDisabled", GameLanguage.CreatingCharactersDisabled);
        reader.Write("Language", "InvalidCharacterName", GameLanguage.InvalidCharacterName);
        reader.Write("Language", "NoClass", GameLanguage.NoClass);
        reader.Write("Language", "ToManyCharacters", GameLanguage.ToManyCharacters);
        reader.Write("Language", "CharacterNameExists", GameLanguage.CharacterNameExists);

        reader.Write("Language", "WarriorsDes", GameLanguage.WarriorsDes);
        reader.Write("Language", "WizardDes", GameLanguage.WizardDes);
        reader.Write("Language", "TaoistDes", GameLanguage.TaoistDes);
        reader.Write("Language", "AssassinDes", GameLanguage.AssassinDes);
        reader.Write("Language", "ArcherDes", GameLanguage.ArcherDes);

        reader.Write("Language", "DateSent", GameLanguage.DateSent);
        reader.Write("Language", "Send", GameLanguage.Send);
        reader.Write("Language", "Reply", GameLanguage.Reply);
        reader.Write("Language", "Read", GameLanguage.Read);
        reader.Write("Language", "Delete", GameLanguage.Delete);
        reader.Write("Language", "BlockList", GameLanguage.BlockList);
        reader.Write("Language", "EnterMailToName", GameLanguage.EnterMailToName);
        reader.Write("Language", "BeenPoisoned", GameLanguage.BeenPoisoned);
        reader.Write("Language", "AddFriend", GameLanguage.AddFriend);
        reader.Write("Language", "RemoveFriend", GameLanguage.RemoveFriend);
        reader.Write("Language", "FriendMemo", GameLanguage.FriendMemo);
        reader.Write("Language", "FriendMail", GameLanguage.FriendMail);
        reader.Write("Language", "FriendWhisper", GameLanguage.FriendWhisper);
        reader.Write("Language", "FriendEnterAddName", GameLanguage.FriendEnterAddName);
        reader.Write("Language", "FriendEnterBlockName", GameLanguage.FriendEnterBlockName);
        reader.Write("Language", "AddMentor", GameLanguage.AddMentor);
        reader.Write("Language", "RemoveMentorMentee", GameLanguage.RemoveMentorMentee);
        reader.Write("Language", "MentorRequests", GameLanguage.MentorRequests);
        reader.Write("Language", "MentorEnterName", GameLanguage.MentorEnterName);
        reader.Write("Language", "NoMentorship", GameLanguage.NoMentorship);
        reader.Write("Language", "RestedBuff", GameLanguage.RestedBuff);

        reader.Write("Language", "ItemTypeWeapon", GameLanguage.ItemTypeWeapon);
        reader.Write("Language", "ItemTypeArmour", GameLanguage.ItemTypeArmour);
        reader.Write("Language", "ItemTypeHelmet", GameLanguage.ItemTypeHelmet);
        reader.Write("Language", "ItemTypeNecklace", GameLanguage.ItemTypeNecklace);
        reader.Write("Language", "ItemTypeBracelet", GameLanguage.ItemTypeBracelet);
        reader.Write("Language", "ItemTypeRing", GameLanguage.ItemTypeRing);
        reader.Write("Language", "ItemTypeAmulet", GameLanguage.ItemTypeAmulet);
        reader.Write("Language", "ItemTypeBelt", GameLanguage.ItemTypeBelt);
        reader.Write("Language", "ItemTypeBoots", GameLanguage.ItemTypeBoots);
        reader.Write("Language", "ItemTypeStone", GameLanguage.ItemTypeStone);
        reader.Write("Language", "ItemTypeTorch", GameLanguage.ItemTypeTorch);
        reader.Write("Language", "ItemTypePotion", GameLanguage.ItemTypePotion);
        reader.Write("Language", "ItemTypeOre", GameLanguage.ItemTypeOre);
        reader.Write("Language", "ItemTypeMeat", GameLanguage.ItemTypeMeat);
        reader.Write("Language", "ItemTypeCraftingMaterial", GameLanguage.ItemTypeCraftingMaterial);
        reader.Write("Language", "ItemTypeScroll", GameLanguage.ItemTypeScroll);
        reader.Write("Language", "ItemTypeGem", GameLanguage.ItemTypeGem);
        reader.Write("Language", "ItemTypeMount", GameLanguage.ItemTypeMount);
        reader.Write("Language", "ItemTypeBook", GameLanguage.ItemTypeBook);
        reader.Write("Language", "ItemTypeScript", GameLanguage.ItemTypeScript);
        reader.Write("Language", "ItemTypeReins", GameLanguage.ItemTypeReins);
        reader.Write("Language", "ItemTypeBells", GameLanguage.ItemTypeBells);
        reader.Write("Language", "ItemTypeSaddle", GameLanguage.ItemTypeSaddle);
        reader.Write("Language", "ItemTypeRibbon", GameLanguage.ItemTypeRibbon);
        reader.Write("Language", "ItemTypeMask", GameLanguage.ItemTypeMask);
        reader.Write("Language", "ItemTypeFood", GameLanguage.ItemTypeFood);
        reader.Write("Language", "ItemTypeHook", GameLanguage.ItemTypeHook);
        reader.Write("Language", "ItemTypeFloat", GameLanguage.ItemTypeFloat);
        reader.Write("Language", "ItemTypeBait", GameLanguage.ItemTypeBait);
        reader.Write("Language", "ItemTypeFinder", GameLanguage.ItemTypeFinder);
        reader.Write("Language", "ItemTypeReel", GameLanguage.ItemTypeReel);
        reader.Write("Language", "ItemTypeFish", GameLanguage.ItemTypeFish);
        reader.Write("Language", "ItemTypeQuest", GameLanguage.ItemTypeQuest);
        reader.Write("Language", "ItemTypeAwakening", GameLanguage.ItemTypeAwakening);
        reader.Write("Language", "ItemTypePets", GameLanguage.ItemTypePets);
        reader.Write("Language", "ItemTypeTransform", GameLanguage.ItemTypeTransform);

        reader.Write("Language", "ItemGradeCommon", GameLanguage.ItemGradeCommon);
        reader.Write("Language", "ItemGradeRare", GameLanguage.ItemGradeRare);
        reader.Write("Language", "ItemGradeLegendary", GameLanguage.ItemGradeLegendary);
        reader.Write("Language", "ItemGradeMythical", GameLanguage.ItemGradeMythical);

        reader.Write("Language", "NoAccountID", GameLanguage.NoAccountID);
        reader.Write("Language", "IncorrectPasswordAccountID", GameLanguage.IncorrectPasswordAccountID);
        reader.Write("Language", "GroupSwitch", GameLanguage.GroupSwitch);
        reader.Write("Language", "GroupAdd", GameLanguage.GroupAdd);
        reader.Write("Language", "GroupRemove", GameLanguage.GroupRemove);
        reader.Write("Language", "GroupAddEnterName", GameLanguage.GroupAddEnterName);
        reader.Write("Language", "GroupRemoveEnterName", GameLanguage.GroupRemoveEnterName);
        reader.Write("Language", "TooHeavyToHold", GameLanguage.TooHeavyToHold);
        reader.Write("Language", "SwitchMarriage", GameLanguage.SwitchMarriage);
        reader.Write("Language", "RequestMarriage", GameLanguage.RequestMarriage);
        reader.Write("Language", "RequestDivorce", GameLanguage.RequestDivorce);
        reader.Write("Language", "MailLover", GameLanguage.MailLover);
        reader.Write("Language", "WhisperLover", GameLanguage.WhisperLover);
    }


    public static void LoadServerLanguage(string languageIniPath)
    {
        if (!File.Exists(languageIniPath))
        {
            SaveServerLanguage(languageIniPath);
            return;
        }
        InIReader reader = new InIReader(languageIniPath);
        GameLanguage.Welcome = reader.ReadString("Language", "Welcome", GameLanguage.Welcome);
        GameLanguage.OnlinePlayers = reader.ReadString("Language", "OnlinePlayers", GameLanguage.OnlinePlayers);
        GameLanguage.LowLevel = reader.ReadString("Language", "LowLevel", GameLanguage.LowLevel);
        GameLanguage.LowGold = reader.ReadString("Language", "LowGold", GameLanguage.LowGold);
        GameLanguage.LowDC = reader.ReadString("Language", "LowDC", GameLanguage.LowDC);
        GameLanguage.LowMC = reader.ReadString("Language", "LowMC", GameLanguage.LowMC);
        GameLanguage.LowSC = reader.ReadString("Language", "LowSC", GameLanguage.LowSC);

        GameLanguage.LevelUp = reader.ReadString("Language", "LevelUp", GameLanguage.LevelUp);

        GameLanguage.WeaponLuck = reader.ReadString("Language", "WeaponLuck", GameLanguage.WeaponLuck);
        GameLanguage.WeaponCurse = reader.ReadString("Language", "WeaponCurse", GameLanguage.WeaponCurse);
        GameLanguage.WeaponNoEffect = reader.ReadString("Language", "WeaponNoEffect", GameLanguage.WeaponNoEffect);

        GameLanguage.InventoryIncreased = reader.ReadString("Language", "InventoryIncreased", GameLanguage.InventoryIncreased);
        GameLanguage.ExpandedStorageExpiresOn = reader.ReadString("Language", "ExpandedStorageExpiresOn", GameLanguage.ExpandedStorageExpiresOn);
        GameLanguage.GameName = reader.ReadString("Language", "GameName", GameLanguage.GameName);
        GameLanguage.FaceToTrade = reader.ReadString("Language", "FaceToTrade", GameLanguage.FaceToTrade);
        GameLanguage.NoTownTeleport = reader.ReadString("Language", "NoTownTeleport", GameLanguage.NoTownTeleport);
        GameLanguage.CanNotRandom = reader.ReadString("Language", "CanNotRandom", GameLanguage.CanNotRandom);
        GameLanguage.CanNotDungeon = reader.ReadString("Language", "CanNotDungeon", GameLanguage.CanNotDungeon);
        GameLanguage.CannotResurrection = reader.ReadString("Language", "CannotResurrection", GameLanguage.CannotResurrection);
        GameLanguage.CanNotDrop = reader.ReadString("Language", "CanNotDrop", GameLanguage.CanNotDrop);

        GameLanguage.NotFemale = reader.ReadString("Language", "NotFemale", GameLanguage.NotFemale);
        GameLanguage.NotMale = reader.ReadString("Language", "NotMale", GameLanguage.NotMale);
        GameLanguage.NotInGuild = reader.ReadString("Language", "NotInGuild", GameLanguage.NotInGuild);
        GameLanguage.NewMail = reader.ReadString("Language", "NewMail", GameLanguage.NewMail);
        GameLanguage.CouldNotFindPlayer = reader.ReadString("Language", "CouldNotFindPlayer", GameLanguage.CouldNotFindPlayer);
        GameLanguage.NoMentorship = reader.ReadString("Language", "NoMentorship", GameLanguage.NoMentorship);
        GameLanguage.NoBagSpace = reader.ReadString("Language", "NoBagSpace", GameLanguage.NoBagSpace);
        GameLanguage.AllowingMentorRequests = reader.ReadString("Language", "AllowingMentorRequests", GameLanguage.AllowingMentorRequests);
        GameLanguage.BlockingMentorRequests = reader.ReadString("Language", "BlockingMentorRequests", GameLanguage.BlockingMentorRequests);
    }

    public static void SaveServerLanguage(string languageIniPath)
    {
        File.Delete(languageIniPath);
        InIReader reader = new InIReader(languageIniPath);
        reader.Write("Language", "Welcome", GameLanguage.Welcome);
        reader.Write("Language", "OnlinePlayers", GameLanguage.OnlinePlayers);
        reader.Write("Language", "LowLevel", GameLanguage.LowLevel);
        reader.Write("Language", "LowGold", GameLanguage.LowGold);
        reader.Write("Language", "LowDC", GameLanguage.LowDC);
        reader.Write("Language", "LowMC", GameLanguage.LowMC);
        reader.Write("Language", "LowSC", GameLanguage.LowSC);

        reader.Write("Language", "LevelUp", GameLanguage.LevelUp);

        reader.Write("Language", "WeaponLuck", GameLanguage.WeaponLuck);
        reader.Write("Language", "WeaponCurse", GameLanguage.WeaponCurse);
        reader.Write("Language", "WeaponNoEffect", GameLanguage.WeaponNoEffect);

        reader.Write("Language", "InventoryIncreased", GameLanguage.InventoryIncreased);
        reader.Write("Language", "ExpandedStorageExpiresOn", GameLanguage.ExpandedStorageExpiresOn);
        reader.Write("Language", "GameName", GameLanguage.GameName);
        reader.Write("Language", "FaceToTrade", GameLanguage.FaceToTrade);
        reader.Write("Language", "NoTownTeleport", GameLanguage.NoTownTeleport);
        reader.Write("Language", "CanNotRandom", GameLanguage.CanNotRandom);
        reader.Write("Language", "CanNotDungeon", GameLanguage.CanNotDungeon);
        reader.Write("Language", "CannotResurrection", GameLanguage.CannotResurrection);
        reader.Write("Language", "CanNotDrop", GameLanguage.CanNotDrop);

        reader.Write("Language", "NotFemale", GameLanguage.NotFemale);
        reader.Write("Language", "NotMale", GameLanguage.NotMale);
        reader.Write("Language", "NotInGuild", GameLanguage.NotInGuild);
        reader.Write("Language", "NewMail", GameLanguage.NewMail);
        reader.Write("Language", "CouldNotFindPlayer", GameLanguage.CouldNotFindPlayer);
        reader.Write("Language", "NoMentorship", GameLanguage.NoMentorship);
        reader.Write("Language", "NoBagSpace", GameLanguage.NoBagSpace);
        reader.Write("Language", "AllowingMentorRequests", GameLanguage.AllowingMentorRequests);
        reader.Write("Language", "BlockingMentorRequests", GameLanguage.BlockingMentorRequests);
    }
}
