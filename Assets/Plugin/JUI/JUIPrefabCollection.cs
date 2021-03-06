using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace JackUtil {

    // [CreateAssetMenu(fileName = "JUIPrefabCollection", menuName = "JUI/JUIPrefabCollection")]
    public class JUIPrefabCollection : MonoBehaviour {

        static JUIPrefabCollection m_instance;
        public static JUIPrefabCollection Instance { get => m_instance; }

        // ---- UI ----
        [Header("UI")]
        public PopupCheckWindow popupCheckWindowPrefab;
        public OptionWindow optionWindowPrefab;
        public OptionButtonGo optionButtonPrefab;
        public DialogWindow dialogWindowPrefab;
        public AlertWindow alertWindowPrefab;
        public NoticeWindow noticeWindowPrefab;
        public NoticeContentGo noticeContentPrefab;
        public BagWindow bagWindowPrefab;
        public SlotGoBase itemPrefab;
        public CurtainWindow curtainWindowPrefab;
        public FloatTextGo floatTextPrefab;

        // ---- WORLD ----
        [Header("World")]
        [Space(5)]
        public TrampolineGo trampolinePrefab;
        public BarGo barPrefab;
        public GameObject swordMeleePrefab;

        void Awake() {

            if (m_instance == null) m_instance = this;

        }

        public void Init() {

            // JackController.GetPopupWindowPrefab += () => popupWindowPrefab;
            // JackController.GetOptionWindowPrefab += () => optionWindowPrefab;
            // JackController.GetOptionButtonPrefab += () => optionButtonPrefab;
            // JackController.GetDialogWindowPrefab += () => dialogWindowPrefab;
            // JackController.GetNoticeWindowPrefab += () => noticeWindowPrefab;
            // JackController.GetBagWindowPrefab += () => bagWindowPrefab;
            // JackController.GetItemPrefab += () => itemPrefab;

            // string uiDirPath = "JUI/Component/UI/";
            // string worldDirPath = "JUI/Component/";

            // if (popupWindowPrefab == null) popupWindowPrefab = Resources.Load<PopupWindow>(uiDirPath + "PopupWindow");
            // if (popupWindowPrefab == null) DebugUtil.LogError("????????????, ?????????");

            // if (optionWindowPrefab == null) optionWindowPrefab = Resources.Load<OptionWindow>(uiDirPath + "OptionWindow");
            // if (optionWindowPrefab == null) DebugUtil.LogError("????????????, ?????????");

            // if (optionButtonPrefab == null) optionButtonPrefab = Resources.Load<OptionButtonGo>(uiDirPath + "OptionButtonPrefab");
            // if (optionButtonPrefab == null) DebugUtil.LogError("????????????, ?????????");

            // if (dialogWindowPrefab == null) dialogWindowPrefab = Resources.Load<DialogWindow>(uiDirPath + "DialogWindow");
            // if (dialogWindowPrefab == null) DebugUtil.LogError("????????????, ?????????");

            // if (noticeWindowPrefab == null) noticeWindowPrefab = Resources.Load<NoticeWindow>(uiDirPath + "NoticeWindow");
            // if (noticeWindowPrefab == null) DebugUtil.LogError("????????????, ?????????");

            // if (alertWindowPrefab == null) alertWindowPrefab = Resources.Load<AlertWindow>(uiDirPath + "AlertWindow");
            // if (alertWindowPrefab == null) DebugUtil.LogError("????????????, ?????????");

            // if (noticeContentPrefab == null) noticeContentPrefab = Resources.Load<NoticeContentGo>(uiDirPath + "NoticeContentPrefab");
            // if (noticeContentPrefab == null) DebugUtil.LogError("????????????, ?????????");

            // if (bagWindowPrefab == null) bagWindowPrefab = Resources.Load<BagWindow>(uiDirPath + "BagWindow");
            // if (bagWindowPrefab == null) DebugUtil.LogError("????????????, ?????????");

            // if (itemPrefab == null) itemPrefab = Resources.Load<ItemGo>(uiDirPath + "ItemPrefab");
            // if (itemPrefab == null) DebugUtil.LogError("????????????, ?????????");

            // // ---- WORLD ----
            // if (trampolinePrefab == null) trampolinePrefab = Resources.Load<TrampolineGo>(worldDirPath + "TrampolinePrefab");
            // if (trampolinePrefab == null) DebugUtil.LogError("????????????, ?????????");

            // if (barPrefab == null) barPrefab = Resources.Load<BarGo>(worldDirPath + "BarPrefab");
            // if (barPrefab == null) DebugUtil.LogError("????????????, ?????????");

        }

    }
}