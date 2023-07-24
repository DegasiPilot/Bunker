using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    List<string> Pol;
    List<string> Profession;
    List<string> Character;
    List<string> Baggage;
    List<string> AdditionalInfo;
    List<string> Hobby;

    Dictionary<string, string> Disaster;

    Dictionary<string, List<string>> ListsDictionary;

    private void Awake()
    {
        ButtonManager.gameManager = this;
        DisasterBtn.gameManager = this;

        Pol = new List<string>
        {
            "�������",
            "�������"
        };

        Profession = new List<string>
        {
            "�����������",
            "��������",
            "���������",
            "�������",
            "�����������",
            "�����������",
            "��������",
            "��������",
            "��������",
            "�����",
            "��������",
            "���������",
            "�����",
            "������",
            "�����",
            "���-��������",
            "���������",
            "������",
            "���-����",
            "�����������",
            "������",
            "�����",
            "�������",
            "�������",
            "��������",
            "�������",
            "�����-�������",
            "�������",
            "���������������",
            "����������",
            "���",
            "�����������",
            "��������",
            "�������",
            "���������",
            "�������",
            "���������",
            "��������",
            "������",
            "���������",
            "�����",
            "���������",
        };

        Character = new List<string>
        {
            "������",
            "������",
            "������",
            "��������������",
            "��������",
            "����������",
            "��������",
            "���������",
            "�������������",
            "���������",
            "����������������",
            "������������",
            "���������",
            "����������",
            "�������",
            "�������������",
            "�����������",
            "���������",
            "������",
            "������",
            "����������",
            "�������������",
            "��������������",
            "����������",
        };

        Baggage = new List<string>
        {
            "������ � ����� ������������",
            "���������� ����������",
            "��������� ����� ������ �����",
            "10 ����� ������",
            "�����",
            "������� � ������",
            "������ ��������� � �����������",
            "������� � �������",
            "�������� � �������� ��������",
            "�������",
            "���������� ����� � ����",
            "����� ���� � �����",
            "��������� � 6 ��������",
            "������� ������� � �����",
            "�������� � ��� �������",
            "�������� �����, ������� � �����",
            "������ � ���������",
            "��� ����� ����������� �����",
            "������� ������ (����)",
            "����� �� �������� ����",
            "�������",
            "������������",
            "������������� � ����������������",
            "������ ����",
            "������� ����� ������",
            "����� ������ ������",
            "������������ �����",
            "����� ��������� ������",
            "������� ���� 100-������ ��������",
            "�������",
            "���������",
            "������������� ����� ����",
            "����� ���� � ������������",
            "����� ����� ����� ��������",
            "����� �������",
            "��������� � ��������� ���������",
            "�������",
            "��������",
            "����� � ����������� ������",
        };

        AdditionalInfo = new List<string>
        {
            "������ ������ �� ��������",
            "����� ����� �������� ����",
            "������ � ��������� ����",
            "������ ����� ����������",
            "����� ������",
            "����� � ������",
            "����� �������� ����",
            "����� ������������ �����",
            "��� ������� ����������",
            "����� ����� � �������������",
            "�������",
            "��� � �������",
            "����� �� ������ �� ���������",
            "����� ������� � ���������",
            "����� ������������� ������",
            "����� ����������� �����",
            "�������� �� ����������� � �����������",
            "������ ���",
            "������� ������ ��� ����� �� ���",
        };

        Hobby = new List<string>
        {
            "������",
            "������������ ����",
            "�������",
            "�����������������",
            "���������",
            "�����",
            "�������",
            "������ ������ ������",
            "������������",
            "���� �� ������",
            "������",
            "������",
            "�������",
            "�����",
            "�����������",
            "������� �� �������",
            "���������",
            "����������",
            "����",
            "�������",
            "���������",
            "������",
            "���",
            "���������� ��������",
            "����������",
            "���������",
            "���������� �����",
            "Ѹ�����",
            "�������",
        };

        Disaster = new Dictionary<string, string>
        {
            {"��������� ����������",
            "�������� ���������� �������� ������ ������, ��� ��� ��������� ������������ ����� ����." +
            "����� ���� ������ ������������ �� ���������� ������ �� �����, ��� ���� ���� ������� ������� �� ����������"},

            {"��������� ������������ ����",
            "����������� ����������� ������������ ����, ������ ��������� ����� � ���������� ������������." +
            "��� �������� ���������� ��������, ���������� ������ ���������� � ��������� ��� ��������." +
            "�� ������� ����� ������ ��� ��������� �� ������� ������ ���������."},

            {"������� �������� ����������",
            "�� ����� �������� ��������� ���������� ������ �� ��� �� �������� ���� ��� ���� �� ������." +
            "����� �������� �� ����������� ���� �����, ���������� �� ��������� ������ ����������."},

            {"������ ����������",
            "�����-�� ����� �������� �� ������ ���������� ���� ����� ��������. �� ����� �������� �� ��� ������ � ������ �� ��� ������, � ����������� ��� ������� � ���������� ����������."},

            {"���� �� �������",
            "�� ����� ����� ����� ������ ����������� ���������. ��� ��������� �������� ������������� �����." +
            "�� ����� ����� ���� � �������, ���������� ��������� � ���������." +
            "�������� �� ��������� ����� ������ ��� �����"},

            {"�����",
            "��������� ���������� �����������, �� ��� �����, ������ �� �������� ���������? ��� �� ��������� ������� ���-������." +
            "������� �������� � ������� ���� ����������� ������ � ���������� ���������� �������"},

            {"����� 2: �������������",
            "����� �������� ���� � ������������� ��������� ���� �������� ���� ������ ��� � ������ ������� �� �����. �� ���-�� �������� ����� �� �� �� ������, � ����� �������. ��������� ���������� ����������. ������� ����, ������� ���� �������������, ������ ���� �� ... ������������?"},

            {"���� ���������",
            "�� ����� ������� ������� ������������� �� ������������� ��������� ������ ������� ������ � ���� ���������." +
            "�� ����� ������ ������ ��������� ������ � �������. � ���� ������� ���������� �� ������, " +
            "����� ��� �� �����������, � ������ �� ����� ������� ��� ������� ������. � ����� ��� ���� ������ " +
            "����������� �����. �� ������ ��������� ���� ����!"},

            {"��������� �����������",
            "����� �����, ������� �� ����, � ��� �� ���� ��� ������� �����-�� ������� �������� � ����������, � ������� � �������������." +
            "������� �������� � ����, ������� ������ ������� ����� � � ������� ��������� ���� ������������."}
        };

        ListsDictionary = new Dictionary<string, List<string>>
        {
            {"Pol",Pol },
            {"Profession", Profession },
            {"Character", Character },
            {"Baggage", Baggage },
            {"AdditionalInfo", AdditionalInfo },
            {"Hobby", Hobby },
        };
    }

    private void Start()
    {
        GenerateAll();
    }

    public string GenerateParametr(string parametr)
    {
        if (parametr == "Age")
        {
            return Random.Range(18, 100).ToString();
        }

        List<string> parametrList = ListsDictionary[parametr];
        return parametrList[Random.Range(0, parametrList.Count)];
    }

    public void GenerateAll()
    {
        foreach (ButtonManager btn in ButtonManager.AllButtons)
        {
            btn.ButtonPressed();
        }
    }

    public KeyValuePair<string, string> GenerateDisaster()
    {
        List<string> DisasterNames = new List<string>(Disaster.Keys);
        string DisasterKey = DisasterNames[Random.Range(0, DisasterNames.Count)];
        return new KeyValuePair<string, string>(DisasterKey, Disaster[DisasterKey]);
    }
}
