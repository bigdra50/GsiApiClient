using UnityEngine;

namespace GsiApiClient.Runtime.Scripts
{
    /// <summary>
    /// 市町村データの変換テーブル
    /// </summary>
    [CreateAssetMenu(fileName = "MuniCd", menuName = "Gsi/MuniTable")]
    public class MuniTable : ScriptableObject
    {
        //public MuniDictionary muniDictionary { get; private set; }

        //private void Awake()
        //{
        //    Initialize();
        //}

        //[ContextMenu(nameof(Initialize))]
        //private void Initialize()
        //{
        //    Debug.Log("Init ScriptableObject");
        //    var muniCsv = Resources.Load<TextAsset>("muniCd").text;
        //    var deserializedTable = CSVSerializer.Deserialize<MuniCdModel>(muniCsv);
        //    Debug.Log($"Loaded MuniTable Length: {deserializedTable.Length}");
        //    muniDictionary = new MuniDictionary();

        //    foreach (var table in deserializedTable)
        //    {
        //        var idx = int.Parse(table.MuniCd) / 10;
        //        muniDictionary.Add(idx, table);
        //    }
        //}

#if UNITY_EDITOR

        //public class MuniCdEditor : Editor
        //{
        //    public override void OnInspectorGUI()
        //    {
        //        base.OnInspectorGUI();
        //        var muniCd = target as MuniTable;
        //        if (muniCd == null) return;
        //        if (GUILayout.Button(nameof(MuniTable.Initialize)))
        //        {
        //            muniCd.Initialize();
        //        }
        //    }
        //}

#endif
    }
}