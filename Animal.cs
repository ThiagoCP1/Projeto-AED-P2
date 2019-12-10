using System;
using System.IO;
using System.Text;
class Animal{
  protected string raca;
  protected int idade;
  protected string cor;
  protected string nome;
  protected float peso;


  public Animal (string raca, int idade, string cor, string nome, float peso){
    this.raca = raca;
    this.idade = idade;
    this.cor = cor;
    this.nome =  nome;
    this.peso = peso;
  }
  public string getRaca(){
    return raca;
  }
  public void setRaca(string r){
    raca = r;
  }
  public int getIdade(){
    return idade;
  }
  public void setIdade(int i){
    idade = i;
  }
  public string getCor(){
    return cor;
  }
  public void setCor(string c){
    cor = c;
  }
  public string getNome(){
    return nome;
  }
  public void setNome(string n){
    nome = n;
  }
  public float getPeso(){
    return peso;
  }
  public void setPeso(float p){
    peso = p;
  }

  public void CadastrarAnimal(string raca, int idade, string cor, string nome, float peso){
    FileStream cadastro = new FileStream("CadastroAnimal.text",FileMode.Append,FileAccess.Write);
    StreamWriter gravarCadastro= new StreamWriter(cadastro, Encoding.UTF7);    
    //string infobasic = dados;
    string gravar = raca + " " + idade + " " + cor + " " + nome + " " + peso; 
    gravarCadastro.WriteLine(raca);
    gravarCadastro.WriteLine(idade);
    
    gravarCadastro.Close();
    cadastro.Close();        

  }

  


}