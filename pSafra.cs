using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using wfaBNG.Linq;
using System.Windows.Forms;
using wfaBNG.Auxiliar;

public class pSafra
{
    // Objetos de Data Contex e Table Usados nos Métodos
    static dataBNGDataContext dc = new dataBNGDataContext();
    static Table<Safra> tSafra = dc.GetTable<Safra>();

    public static void UpdateDC()
    {
        dc = new dataBNGDataContext();

        tSafra = dc.GetTable<Safra>();
    }

    /// <summary>
    /// Maurício - Inclusão - 08/12/2010
    /// Método para Criar um Objeto
    /// </summary>
    /// <returns></returns>
    public static Safra Create()
    {
        Safra s = new Safra();
        s.objID = Guid.NewGuid().ToString();

        return s;
    }

    /// <summary>
    ///  Maurício - Inclusão - 08/12/2010
    ///  Método para inserir objeto na tabela
    /// </summary>
    /// <param name="pobjSafra"></param>
    public static void Insert(Safra pobjSafra)
    {
        tSafra.InsertOnSubmit(pobjSafra);
        dc.SubmitChanges();
    }

    /// <summary>
    ///  Maurício - Inclusão - 08/12/2010
    ///  Método para carregar o Objeto
    /// </summary>
    /// <param name="pobjIDSafra"></param>
    /// <returns></returns>
    public static Safra Load(String pobjIDSafra)
    {
        UpdateDC();
        var oSafra = (from s in tSafra
                      where s.objID.Equals(pobjIDSafra)
                      select s).SingleOrDefault();
        return oSafra;
    }

    /// <summary>
    ///  Maurício - Inclusão - 08/12/2010
    ///  Método para atualizar o Objeto
    /// </summary>
    /// <param name="pobjSafra"></param>
    public static void Update(Safra pobjSafra)
    {
        var oSafra = (from s in tSafra
                      where s.objID.Equals(pobjSafra.objID)
                      select s).SingleOrDefault();

        oSafra.objID = pobjSafra.objID;
        oSafra.anoInicial = pobjSafra.anoInicial;
        oSafra.anoFinal = pobjSafra.anoFinal;
        oSafra.descricao = pobjSafra.descricao;

        dc.SubmitChanges();
    }

    /// <summary>
    ///  Maurício - Inclusão - 08/12/2010
    ///  Método para Deletar um Objeto
    /// </summary>
    /// <param name="pobjSafra"></param>
    public static void Delete(Safra pobjSafra)
    {
        var oSafra = (from s in tSafra
                      where s.objID.Equals(pobjSafra.objID)
                      select s).SingleOrDefault();

        tSafra.DeleteOnSubmit(pobjSafra);
        dc.SubmitChanges();
    }

    /// <summary>
    ///  Maurício - Inclusão - 08/12/2010
    ///  Método que retorna todos os Objetos da Classe
    /// </summary>
    /// <returns></returns>
    public static List<Safra> ReturnAll()
    {
        UpdateDC();
        var cSafra = (from s in tSafra
                      orderby s.descricao descending
                      select s).ToList<Safra>();
        return cSafra;
    }



/////////////////////////////////////////////////////////////////////////////////////




    /// <summary>
    /// 06/01/2011 - Elton - inclusão
    /// Retorna todas as safras de uma propriedade
    /// </summary>
    /// <param name="pobjProprietario"></param>
    /// <returns></returns>
    public static List<Safra> ReturnAll(PropriedadeRural pobjPropriedade)
    {
        UpdateDC();
        List<Safra> lSafra = new List<Safra>();
        List<AreaSafra> lsAreaS = pVAreaSafra.ReturnAll(pobjPropriedade);
        List<String> ids = new List<String>();
        foreach (AreaSafra areasafra in lsAreaS)
        {
            ids.Add(areasafra.IDSafra);
        }

        ids = ids.Distinct().ToList();

        foreach (String idsafra in ids)
        {
            lSafra.Add(pSafra.Load(idsafra));
        }

        return lSafra.OrderByDescending(o=>o.descricao).ToList();
    }

    /// <summary>
    /// 09/12/2010- Jefferson- Inclusão
    /// 
    /// Método que retorna todos os objetos através da Descrição
    /// </summary>
    /// <param name="pDescricao"></param>
    /// <returns></returns>
    public static List<Safra> ReturnAll(String pDescricao)
    {
        UpdateDC();
        var cSafra = (from c in tSafra
                      where c.descricao.Contains(pDescricao)
                      orderby c.descricao ascending
                      select c).ToList();
        return cSafra;
    }

    /// <summary>
    /// 22/07/2015 - Poliana - Inclusão
    /// 
    /// Método retorna todos as safras de Projetos do Proprietario
    /// </summary>
    /// <param name="pProprietario"></param>
    /// <returns></returns>
    public static List<Safra> ReturnAll(Proprietario pProprietario)
    {
        UpdateDC();
        String consulta = "SELECT * FROM Safra where Safra.objID in (SELECT Distinct Projeto.IDSafra from Projeto INNER JOIN Proprietario ON Projeto.IDProprietario = '" + pProprietario.objID + "') order by Safra.descricao desc";

        var oSafra = dc.ExecuteQuery<Safra>(consulta).ToList<Safra>();

        return oSafra;
    }


    /// <summary>
    /// 22/07/2015 - Poliana - Inclusão
    /// 
    /// Método retorna todos os objetos através do Proprietario, desde que estes tenha vinculo com PlanAreaVariedade
    /// </summary>
    /// <param name="pProprietario"></param>
    /// <returns></returns>
    public static List<Safra> ReturnAllByPlanVar(Proprietario pObjProprietario)
    {
        UpdateDC();
        StringBuilder consulta = new StringBuilder();
        consulta.Append("SELECT * FROM Safra where Safra.objID in (SELECT  Projeto.IDSafra from Projeto right Join PlanVariedade on Projeto.objID = PlanVariedade.IDProjeto right Join PlanAreaVariedade on PlanAreaVariedade.IDPlanVariedade = PlanVariedade.objID where  Projeto.IDProprietario = '"+  pObjProprietario.objID +"') order by Safra.descricao desc");

        var oSafra = dc.ExecuteQuery<Safra>(consulta.ToString()).ToList<Safra>();

        return oSafra;
    }

    /// <summary>
    /// Retorna Safra que tem vinculo com Ares
    /// </summary>
    /// <returns></returns>
    public static List<Safra> ReturnAllDistinct()
    {
        StringBuilder query = new StringBuilder();
        query.Append(" SELECT * FROM safra");
        query.Append(" WHERE descricao in (");
        query.Append(" SELECT DISTINCT(descricao) FROM Safra");
        query.Append(" INNER JOIN AreaSafra ON AreaSafra.IDSafra = Safra.objID)");

        return dc.ExecuteQuery<Safra>(query.ToString()).ToList();
    }

    /// <summary>
    /// Retorna todas as Safras posteriores a corrente
    /// </summary>
    /// <param name="pobjSafra"></param>
    /// <returns></returns>
    public static List<Safra> ReturnAllLater(Safra pobjSafra)
    {
        UpdateDC();
        var cSafra = (from s in tSafra
                      where s.anoInicial > pobjSafra.anoInicial
                      where s.anoFinal > pobjSafra.anoFinal
                      orderby s.anoInicial, s.anoFinal, s.descricao ascending
                      select s).ToList();
        return cSafra;
    }

    /// <summary>
    /// Retorna o 1º objeto posterior ao corrente
    /// </summary>
    /// <param name="pobjSafra"></param>
    /// <returns></returns>
    public static Safra ReturnLater(Safra pobjSafra)
    {
        UpdateDC();
        var cSafra = (from s in tSafra
                      where s.anoInicial > pobjSafra.anoInicial
                      where s.anoFinal > pobjSafra.anoFinal
                      orderby s.anoInicial, s.anoFinal, s.descricao ascending
                      select s).FirstOrDefault();
        return cSafra;
    }
	

    public static Safra ReturnBefore(int Safra)
    {
        UpdateDC();
        var cSafra = (from s in tSafra
                      where s.anoInicial == (Safra - 1)
                      select s).FirstOrDefault();
        return cSafra;
    }

    /// <summary>
    /// Retorna o 1º objeto anterior ao corrente
    /// </summary>
    /// <param name="pobjSafra"></param>
    /// <returns></returns>
    public static Safra ReturnPrevious(Safra pobjSafra)
    {
        UpdateDC();
        var cSafra = (from s in tSafra
                      where s.anoInicial < pobjSafra.anoInicial && s.anoFinal < pobjSafra.anoFinal
                      orderby s.anoInicial descending
                      select s).FirstOrDefault();
        return cSafra;
    }

    public static int CountSameAnoInicial(Safra pobjSafra)
    {
        int ct = 0;

        UpdateDC();
        ct = (from s in tSafra
              where s.anoInicial == pobjSafra.anoInicial && !s.objID.Equals(pobjSafra.objID)
              select s).Count();

        return ct;
    }

    public static void LoadCmb(ComboBox pCmb)
    {
        List<Safra> lst = new List<Safra>();
        lst.Add(new Safra());
        lst.AddRange(ReturnAll());

        pCmb.DataSource = lst;
        pCmb.DisplayMember = "descricao";
        pCmb.ValueMember = "objID";
    }
}