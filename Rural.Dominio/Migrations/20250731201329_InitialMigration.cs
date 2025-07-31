using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Rural.Dominio.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Campeonato",
                columns: table => new
                {
                    IdCampeonato = table.Column<string>(unicode: false, fixedLength: true, maxLength: 10, nullable: false),
                    Descricao = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
                    DataInicio = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataFinal = table.Column<DateTime>(type: "datetime", nullable: true),
                    EmAndamento = table.Column<bool>(nullable: false),
                    Finalizado = table.Column<bool>(nullable: false),
                    Tipo = table.Column<int>(nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campeonato", x => x.IdCampeonato);
                });

            migrationBuilder.CreateTable(
                name: "Estadio",
                columns: table => new
                {
                    IdEstadio = table.Column<string>(unicode: false, fixedLength: true, maxLength: 10, nullable: false),
                    Descricao = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
                    Localidade = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    DataCadastro = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estadio", x => x.IdEstadio);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    IdUsuario = table.Column<string>(nullable: false),
                    Login = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Senha = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.IdUsuario);
                });

            migrationBuilder.CreateTable(
                name: "Jogos",
                columns: table => new
                {
                    IdJogos = table.Column<string>(unicode: false, fixedLength: true, maxLength: 10, nullable: false),
                    IdCampeonato = table.Column<string>(unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    Rodada = table.Column<int>(nullable: false),
                    IdClubeCasa = table.Column<string>(unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    IdClubeVisitante = table.Column<string>(unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    Quadro = table.Column<int>(nullable: false),
                    PlacarCasar = table.Column<int>(nullable: false),
                    PlacarVisitante = table.Column<int>(nullable: false),
                    Data = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jogos", x => x.IdJogos);
                    table.ForeignKey(
                        name: "FK_Jogos_Campeonato",
                        column: x => x.IdCampeonato,
                        principalTable: "Campeonato",
                        principalColumn: "IdCampeonato",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Clube",
                columns: table => new
                {
                    IdClube = table.Column<string>(unicode: false, fixedLength: true, maxLength: 10, nullable: false),
                    Descricao = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
                    Tecnico = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    Auxiliar = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    Massagista = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    IdEstadio = table.Column<string>(unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    Imagem = table.Column<string>(unicode: false, nullable: true),
                    DataCadastro = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clube", x => x.IdClube);
                    table.ForeignKey(
                        name: "FK_Clube_Estadio",
                        column: x => x.IdEstadio,
                        principalTable: "Estadio",
                        principalColumn: "IdEstadio",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sumula",
                columns: table => new
                {
                    IdSumula = table.Column<string>(unicode: false, fixedLength: true, maxLength: 10, nullable: false),
                    IdCampeonato = table.Column<string>(unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    IdJogos = table.Column<string>(unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    Observacao = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Data = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sumula", x => x.IdSumula);
                    table.ForeignKey(
                        name: "FK_Sumula_Campeonato",
                        column: x => x.IdCampeonato,
                        principalTable: "Campeonato",
                        principalColumn: "IdCampeonato",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sumula_Jogos",
                        column: x => x.IdJogos,
                        principalTable: "Jogos",
                        principalColumn: "IdJogos",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Classificacao",
                columns: table => new
                {
                    IdClassificacao = table.Column<string>(unicode: false, fixedLength: true, maxLength: 10, nullable: false),
                    IdCampeonato = table.Column<string>(unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    IdClube = table.Column<string>(unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    Vitoria = table.Column<decimal>(type: "decimal(18, 6)", nullable: true),
                    Empate = table.Column<decimal>(type: "decimal(18, 6)", nullable: true),
                    Derrota = table.Column<decimal>(type: "decimal(18, 6)", nullable: true),
                    SaldoGols = table.Column<decimal>(type: "decimal(18, 6)", nullable: true),
                    GolsPro = table.Column<decimal>(type: "decimal(18, 6)", nullable: true),
                    GolsContra = table.Column<decimal>(type: "decimal(18, 6)", nullable: true),
                    CartaoAmarelo = table.Column<decimal>(type: "decimal(18, 6)", nullable: true),
                    CartaoVermelho = table.Column<decimal>(type: "decimal(18, 6)", nullable: true),
                    Quadro = table.Column<int>(nullable: false),
                    UltimaAtualizacao = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classificacao", x => x.IdClassificacao);
                    table.ForeignKey(
                        name: "FK_Classificacao_Campeonato",
                        column: x => x.IdCampeonato,
                        principalTable: "Campeonato",
                        principalColumn: "IdCampeonato",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Classificacao_Clube",
                        column: x => x.IdClube,
                        principalTable: "Clube",
                        principalColumn: "IdClube",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Jogador",
                columns: table => new
                {
                    IdJogador = table.Column<string>(unicode: false, fixedLength: true, maxLength: 10, nullable: false),
                    Nome = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime", nullable: true),
                    Documento = table.Column<long>(nullable: true),
                    IdClube = table.Column<string>(unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    Imagem = table.Column<string>(unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jogador", x => x.IdJogador);
                    table.ForeignKey(
                        name: "FK_Jogador_Clube",
                        column: x => x.IdClube,
                        principalTable: "Clube",
                        principalColumn: "IdClube",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InfoCampeonato",
                columns: table => new
                {
                    IdInfoCampeonato = table.Column<string>(unicode: false, fixedLength: true, maxLength: 10, nullable: false),
                    IdCampeonato = table.Column<string>(unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    IdClube = table.Column<string>(unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    IdJogador = table.Column<string>(unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    Gols = table.Column<decimal>(type: "decimal(18, 6)", nullable: true),
                    CartaoAmarelo = table.Column<decimal>(type: "decimal(18, 6)", nullable: true),
                    CartaoVermelho = table.Column<decimal>(type: "decimal(18, 6)", nullable: true),
                    Suspenso = table.Column<bool>(nullable: false),
                    Quadro = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InfoCampeonato", x => x.IdInfoCampeonato);
                    table.ForeignKey(
                        name: "FK_InfoCampeonato_Campeonato",
                        column: x => x.IdCampeonato,
                        principalTable: "Campeonato",
                        principalColumn: "IdCampeonato",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InfoCampeonato_Clube",
                        column: x => x.IdClube,
                        principalTable: "Clube",
                        principalColumn: "IdClube",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InfoCampeonato_Jogador",
                        column: x => x.IdJogador,
                        principalTable: "Jogador",
                        principalColumn: "IdJogador",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SumulaDetalhes",
                columns: table => new
                {
                    IdSumulaDetalhes = table.Column<string>(unicode: false, fixedLength: true, maxLength: 10, nullable: false),
                    IdSumula = table.Column<string>(unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    IdClube = table.Column<string>(unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    IdJogador = table.Column<string>(unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    Gols = table.Column<decimal>(type: "decimal(18, 6)", nullable: true),
                    CartaoAmarelo = table.Column<decimal>(type: "decimal(18, 6)", nullable: true),
                    CartaoVermelho = table.Column<decimal>(type: "decimal(18, 6)", nullable: true),
                    Quadro = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SumulaDetalhes", x => x.IdSumulaDetalhes);
                    table.ForeignKey(
                        name: "FK_SumulaDetalhes_Clube",
                        column: x => x.IdClube,
                        principalTable: "Clube",
                        principalColumn: "IdClube",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SumulaDetalhes_Jogador",
                        column: x => x.IdJogador,
                        principalTable: "Jogador",
                        principalColumn: "IdJogador",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SumulaDetalhes_Sumula",
                        column: x => x.IdSumula,
                        principalTable: "Sumula",
                        principalColumn: "IdSumula",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Campeonato_Descricao",
                table: "Campeonato",
                column: "Descricao");

            migrationBuilder.CreateIndex(
                name: "IX_Classificacao_IdCampeonato",
                table: "Classificacao",
                column: "IdCampeonato");

            migrationBuilder.CreateIndex(
                name: "IX_Classificacao_IdClube",
                table: "Classificacao",
                column: "IdClube");

            migrationBuilder.CreateIndex(
                name: "IX_Clube_Auxiliar",
                table: "Clube",
                column: "Auxiliar");

            migrationBuilder.CreateIndex(
                name: "IX_Clube_Descricao",
                table: "Clube",
                column: "Descricao");

            migrationBuilder.CreateIndex(
                name: "IX_Clube_IdEstadio",
                table: "Clube",
                column: "IdEstadio");

            migrationBuilder.CreateIndex(
                name: "IX_Clube_Massagista",
                table: "Clube",
                column: "Massagista");

            migrationBuilder.CreateIndex(
                name: "IX_Clube_Tecnico",
                table: "Clube",
                column: "Tecnico");

            migrationBuilder.CreateIndex(
                name: "IX_Estadio_Descricao",
                table: "Estadio",
                column: "Descricao");

            migrationBuilder.CreateIndex(
                name: "IX_Estadio_Localidade",
                table: "Estadio",
                column: "Localidade");

            migrationBuilder.CreateIndex(
                name: "IX_InfoCampeonato_IdCampeonato",
                table: "InfoCampeonato",
                column: "IdCampeonato");

            migrationBuilder.CreateIndex(
                name: "IX_InfoCampeonato_IdClube",
                table: "InfoCampeonato",
                column: "IdClube");

            migrationBuilder.CreateIndex(
                name: "IX_InfoCampeonato_IdJogador",
                table: "InfoCampeonato",
                column: "IdJogador");

            migrationBuilder.CreateIndex(
                name: "IX_Jogador_IdClube",
                table: "Jogador",
                column: "IdClube");

            migrationBuilder.CreateIndex(
                name: "IX_Jogador_Nome",
                table: "Jogador",
                column: "Nome");

            migrationBuilder.CreateIndex(
                name: "IX_Jogos_IdCampeonato",
                table: "Jogos",
                column: "IdCampeonato");

            migrationBuilder.CreateIndex(
                name: "IX_Sumula_IdCampeonato",
                table: "Sumula",
                column: "IdCampeonato");

            migrationBuilder.CreateIndex(
                name: "IX_Sumula_IdJogos",
                table: "Sumula",
                column: "IdJogos");

            migrationBuilder.CreateIndex(
                name: "IX_SumulaDetalhes_IdClube",
                table: "SumulaDetalhes",
                column: "IdClube");

            migrationBuilder.CreateIndex(
                name: "IX_SumulaDetalhes_IdJogador",
                table: "SumulaDetalhes",
                column: "IdJogador");

            migrationBuilder.CreateIndex(
                name: "IX_SumulaDetalhes_IdSumula",
                table: "SumulaDetalhes",
                column: "IdSumula");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Classificacao");

            migrationBuilder.DropTable(
                name: "InfoCampeonato");

            migrationBuilder.DropTable(
                name: "SumulaDetalhes");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Jogador");

            migrationBuilder.DropTable(
                name: "Sumula");

            migrationBuilder.DropTable(
                name: "Clube");

            migrationBuilder.DropTable(
                name: "Jogos");

            migrationBuilder.DropTable(
                name: "Estadio");

            migrationBuilder.DropTable(
                name: "Campeonato");
        }
    }
}
