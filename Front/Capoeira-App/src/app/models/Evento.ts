export interface Evento {
  id: number;
  local: string;
  dataEvento?: Date;
  tema: string;
  qtdPessoas: number;
  imagemUrl: string;
  telefone: string;
  email: string;
}
