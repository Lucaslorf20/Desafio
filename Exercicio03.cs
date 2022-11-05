using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Linq;

public class Tags
{
  public Row row { get;set; }
}

public class Row
{
    public int dia { get; set; }
    public decimal valor{ get; set; }
}

class Program {
  public static void Main (string[] args) {
    
    var serializer = new XmlSerializer(typeof(Tags));
    var configuracao = new Tags();
    var localArquivo = "C:/arquivo.xml";
  
    using (var textReader = new StreamReader(localDoArquivo))
    {
        configuracao = (Tags)serializer.Deserialize(textReader);
    }

    List<Row> linhas = configuracao.toList();
    Row maximo = linhas.FirstOrDefault(x=> x.valor == linhas.Max(x=> x.valor));
    Row minimo = linhas.FirstOrDefault(x=> x.valor == linhas.Min(x=> x.valor));
    decimal media = linhas.Where(x=> x.valor != 0).Average(x=> x.valor);
    List<Row> acimaMedia = linhas.Where(x=> x.valor > media).toList();

    
  }
}