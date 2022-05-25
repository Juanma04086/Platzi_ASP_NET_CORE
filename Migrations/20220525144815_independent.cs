using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Platzi_ASP_NET_CORE.Migrations
{
    public partial class independent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Escuelas",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AñoDeCreación = table.Column<int>(type: "int", nullable: true),
                    Pais = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dirección = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoEscuela = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Escuelas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cursos",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Jornada = table.Column<int>(type: "int", nullable: false),
                    Dirección = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EscuelaId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cursos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cursos_Escuelas_EscuelaId",
                        column: x => x.EscuelaId,
                        principalTable: "Escuelas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Alumnos",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CursoId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alumnos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Alumnos_Cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "Cursos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Asignaturas",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CursoId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asignaturas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Asignaturas_Cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "Cursos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Evaluaciones",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AlumnoId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AsignaturaId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nota = table.Column<float>(type: "real", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evaluaciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Evaluaciones_Alumnos_AlumnoId",
                        column: x => x.AlumnoId,
                        principalTable: "Alumnos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Evaluaciones_Asignaturas_AsignaturaId",
                        column: x => x.AsignaturaId,
                        principalTable: "Asignaturas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Alumnos",
                columns: new[] { "Id", "CursoId", "Nombre" },
                values: new object[,]
                {
                    { "014f2c08-4307-4331-9c8a-771e7a91ff73", null, "Donald Silvana Herrera" },
                    { "01cb5738-45cb-460e-bb97-4588724c7436", null, "Felipa Freddy Uribe" },
                    { "01d38d3f-b91e-4df6-a91a-7d0f3d7f2ddb", null, "Eusebio Murty Ruiz" },
                    { "02328a29-b631-40c4-a237-c970bf8c566b", null, "Donald Murty Trump" },
                    { "02d806a2-837a-4169-b722-74cd9736ded2", null, "Nicolás Nicomedes Ruiz" },
                    { "02dda57d-9271-43da-8495-3e76ad03c445", null, "Eusebio Nicomedes Sarmiento" },
                    { "02e5ff0f-15fb-41d9-b405-8568afa17781", null, "Farid Rick Herrera" },
                    { "0343f0e7-680e-4350-a735-89b68432d4c3", null, "Eusebio Diomedes Maduro" },
                    { "0388e9d9-8651-41de-b8fb-e4290239f7c3", null, "Nicolás Rick Maduro" },
                    { "059a9a23-4048-46a3-83a9-e83d72fc4176", null, "Alvaro Murty Uribe" },
                    { "07acf5b8-b664-4471-b0eb-549c1247ee4f", null, "Nicolás Murty Sarmiento" },
                    { "07d7662f-508c-4172-9aca-ef42e6c2dd68", null, "Felipa Murty Ruiz" },
                    { "086146fe-5525-479b-823b-d61a2bb232cc", null, "Felipa Freddy Sarmiento" },
                    { "08a5c13f-fb38-4a43-9fa4-19746265cabe", null, "Donald Teodoro Ruiz" },
                    { "08b82da6-9a9f-4ff5-9d34-6e879119929d", null, "Alvaro Diomedes Maduro" },
                    { "096077f3-14e1-4789-a255-cf4a7bc0cd7d", null, "Felipa Silvana Maduro" },
                    { "0abe3e23-941c-48bc-89c1-ca4465ba951a", null, "Nicolás Teodoro Maduro" },
                    { "0d586482-3131-4b97-83b1-207a528099ca", null, "Felipa Anabel Herrera" },
                    { "0deb31c8-8584-4770-9151-5939091a50ef", null, "Donald Freddy Sarmiento" },
                    { "0df42ddb-8b0e-444d-8340-1b89ca6cf327", null, "Eusebio Diomedes Toledo" },
                    { "0e0c11a3-4c30-4d6d-8d24-24dbee6129f0", null, "Alba Rick Trump" },
                    { "0f6f34e1-1a97-497f-bb40-026e917fa127", null, "Alba Teodoro Ruiz" },
                    { "0fc702c4-e07f-4370-a019-129c1dfe0717", null, "Eusebio Silvana Sarmiento" },
                    { "100577da-caf1-4eee-8250-6f73f3c04723", null, "Farid Rick Toledo" },
                    { "104da80d-e2cf-496e-8662-168682dc00b2", null, "Felipa Silvana Herrera" },
                    { "109b17db-2659-4d48-b259-161dee16537c", null, "Alvaro Murty Trump" },
                    { "11caf9e7-853b-4100-957b-d60b9da773a1", null, "Felipa Rick Toledo" },
                    { "12f9a5f3-cf23-478b-9ac8-a315092ab501", null, "Farid Teodoro Toledo" },
                    { "135a35b2-5e84-4b78-a09d-1fb5241e7b4b", null, "Farid Freddy Maduro" },
                    { "142132b4-46ce-41d4-a33f-6af0935b8f3f", null, "Donald Rick Toledo" },
                    { "1499ee8c-ee1e-429c-b572-5714742c2775", null, "Eusebio Anabel Herrera" },
                    { "149b011c-f054-4e85-a1e4-472d26597a10", null, "Alvaro Teodoro Sarmiento" },
                    { "14a77ea1-8eda-4fa7-b2ca-113b2459dc3f", null, "Donald Murty Sarmiento" },
                    { "14eb142a-4aff-487a-8bb2-7b28271fea81", null, "Donald Teodoro Maduro" },
                    { "158ce168-6565-478a-a2f9-6ae978a1ff59", null, "Alvaro Silvana Maduro" },
                    { "15c8caa3-1aad-42f7-98fc-bf66dd946de9", null, "Farid Silvana Maduro" },
                    { "172f7162-25f0-435c-a0cd-b53b40a8a182", null, "Eusebio Murty Sarmiento" },
                    { "180ad767-a054-4a9c-9099-1acded145eda", null, "Alvaro Silvana Sarmiento" },
                    { "185fd04e-45da-477e-894c-35ec61cf0045", null, "Alvaro Diomedes Toledo" },
                    { "1900aa74-ef07-4036-8248-55322492c382", null, "Alvaro Nicomedes Trump" },
                    { "190b760a-373c-410c-8ae4-10715451f9a7", null, "Farid Silvana Trump" },
                    { "19d9480b-ab91-42d4-8db0-1cf0576df970", null, "Felipa Rick Trump" }
                });

            migrationBuilder.InsertData(
                table: "Alumnos",
                columns: new[] { "Id", "CursoId", "Nombre" },
                values: new object[,]
                {
                    { "1a3c036b-be9d-4aec-9926-7654b36e59ae", null, "Nicolás Nicomedes Herrera" },
                    { "1af67c42-7a16-4115-9e25-2788c7505502", null, "Farid Freddy Uribe" },
                    { "1b0d6b25-ec14-41f0-9ee7-08c37d5cf627", null, "Eusebio Murty Maduro" },
                    { "1ba21548-5392-475b-8064-1422361fa222", null, "Alba Freddy Maduro" },
                    { "1c0cc94d-730b-4ddf-80f4-cc16cee9631f", null, "Alvaro Rick Herrera" },
                    { "1d099ef1-f2ca-4270-af45-811f25e8dbf8", null, "Nicolás Teodoro Ruiz" },
                    { "1f4860bf-652a-4426-aa6c-678a05ecafef", null, "Eusebio Freddy Maduro" },
                    { "1f4d8406-44ea-426d-9675-9125ad269157", null, "Alba Freddy Ruiz" },
                    { "1fa0786e-eef6-4438-8541-84558aedd3a3", null, "Eusebio Nicomedes Trump" },
                    { "1fafdb01-94bb-4853-a128-4989b5849124", null, "Alvaro Diomedes Herrera" },
                    { "1fe629ff-28d9-4b1b-a118-155995fa3892", null, "Felipa Silvana Ruiz" },
                    { "1ff8d546-f282-4afd-b181-29ba371b97ee", null, "Alba Anabel Trump" },
                    { "208e69ca-7e41-44da-8e15-34fd9fcb60fc", null, "Alba Anabel Herrera" },
                    { "2092ca07-1ca7-4bd8-8343-ad8479c69015", null, "Farid Silvana Ruiz" },
                    { "214c858a-d7dd-4606-832e-78f60bec719c", null, "Alvaro Rick Maduro" },
                    { "244ed13b-9643-4f84-a8e6-c54d30220987", null, "Alba Nicomedes Uribe" },
                    { "2498d05e-e9e1-47ba-aed5-cf62fe155614", null, "Nicolás Freddy Maduro" },
                    { "24f0112c-7298-4981-a968-8a5633635d07", null, "Nicolás Freddy Toledo" },
                    { "25013ea0-2785-49af-b6eb-1add1ea1a26e", null, "Farid Murty Maduro" },
                    { "2523d1dd-db76-4302-847f-5613c3946973", null, "Felipa Diomedes Trump" },
                    { "26b42325-9ef0-4cfe-b2c0-4d72ccdbfd88", null, "Eusebio Murty Toledo" },
                    { "27ef5cfe-1f14-4e3e-b578-4cf920b738cb", null, "Felipa Anabel Toledo" },
                    { "28f0bc72-c656-4d16-8368-8ff000a5ba69", null, "Felipa Murty Trump" },
                    { "29d3a847-6e0e-4a1a-9150-59e850ce0a6e", null, "Farid Silvana Sarmiento" },
                    { "2b5960d2-c4f1-47e6-9813-2bc4c7a15c6a", null, "Alvaro Anabel Uribe" },
                    { "2bb587c4-4db7-4b60-b73f-e865ba08f7a6", null, "Alba Murty Toledo" },
                    { "2c29401d-0f8a-4ccb-85bb-5bbe4d087489", null, "Alba Freddy Toledo" },
                    { "2c8f1807-3b2c-4dfd-a658-6ad66f04896a", null, "Alba Diomedes Sarmiento" },
                    { "2d2b4b8d-92aa-44de-816f-f91354c6f750", null, "Nicolás Silvana Herrera" },
                    { "2df582ba-d623-47e6-acd9-515786c81aca", null, "Farid Nicomedes Toledo" },
                    { "2e242f22-eb68-48c0-b613-97ee03a275f8", null, "Farid Teodoro Maduro" },
                    { "2efdc03a-7baa-46af-9949-a78486acf027", null, "Farid Nicomedes Uribe" },
                    { "2f4be8c6-064f-4cd4-955a-c674a401ed44", null, "Alvaro Rick Uribe" },
                    { "2f88a367-38b3-41ff-9b61-c53145a0c3a6", null, "Alba Diomedes Uribe" },
                    { "2f8ecaef-b25a-4da4-a62b-cd3c7a40bd1e", null, "Nicolás Nicomedes Trump" },
                    { "30427b85-1c1c-46e6-9c2d-4c7bf26b5316", null, "Alba Rick Sarmiento" },
                    { "304bd886-bf8b-4399-a26b-bdcd3bd70130", null, "Donald Murty Herrera" },
                    { "304d108d-0d57-4be6-8695-2c9225858b4d", null, "Alba Murty Sarmiento" },
                    { "310bbae4-6ea6-46c0-b27b-fc495bb3b3c9", null, "Alba Anabel Toledo" },
                    { "325eabe7-9084-40e7-9fa9-060fea195a14", null, "Donald Nicomedes Toledo" },
                    { "32de3add-01b8-4848-94fa-7d286f57f5a3", null, "Alvaro Anabel Sarmiento" },
                    { "32e9e6f8-d2d7-43c2-b51f-c823af9e6caf", null, "Nicolás Teodoro Herrera" }
                });

            migrationBuilder.InsertData(
                table: "Alumnos",
                columns: new[] { "Id", "CursoId", "Nombre" },
                values: new object[,]
                {
                    { "3452f425-738a-4dde-912b-6c673f5632bf", null, "Farid Freddy Ruiz" },
                    { "34878d9c-4df6-4773-9b28-e479ed7c6df0", null, "Felipa Silvana Toledo" },
                    { "3498e08c-cd43-401e-b620-099333d9651b", null, "Nicolás Murty Maduro" },
                    { "3613e759-bc8b-4ad4-a4ce-98cd815becf6", null, "Farid Rick Maduro" },
                    { "3624d967-0b23-4bfd-9dc9-9b1049ea4782", null, "Farid Teodoro Ruiz" },
                    { "3684f667-2444-4518-9097-7a9b939b7214", null, "Donald Teodoro Sarmiento" },
                    { "3729d36d-8d07-4738-a2a8-a92e7789e694", null, "Farid Teodoro Trump" },
                    { "37de46ea-b831-4c9f-b685-da589a4e9db3", null, "Felipa Silvana Trump" },
                    { "3a0999ce-e63f-446d-af83-9daa54d6b897", null, "Farid Anabel Sarmiento" },
                    { "3a1dafeb-872d-4196-844f-e2f4225f61d7", null, "Donald Silvana Maduro" },
                    { "3aa46a23-445c-4eeb-b32e-a816cf17f71d", null, "Alba Freddy Sarmiento" },
                    { "3b29555d-17da-4319-9fc0-77fea66a977f", null, "Felipa Freddy Toledo" },
                    { "3bbab54e-0d59-4ca1-a92d-db64c0de1a22", null, "Alba Murty Ruiz" },
                    { "3ceef899-ddca-423e-91ec-d0a1c8a7143a", null, "Eusebio Anabel Uribe" },
                    { "3dd2201a-e688-4f92-b88e-d7a92cc0a05a", null, "Alvaro Murty Ruiz" },
                    { "3dd250a5-8ccc-4953-9f34-60a86196fa86", null, "Felipa Nicomedes Maduro" },
                    { "3e08edd9-8029-48c0-b773-9526f2609491", null, "Donald Rick Trump" },
                    { "3e86a4d4-ce05-42ce-ae15-f2054864771f", null, "Eusebio Rick Herrera" },
                    { "3f30b286-524f-4d5a-b5c9-42a040180dc3", null, "Nicolás Murty Toledo" },
                    { "3f8e87a0-9661-480b-b192-30728652cb1a", null, "Donald Teodoro Uribe" },
                    { "3f95e074-0c7e-4f7a-aafd-28ddf126f2b4", null, "Alvaro Anabel Maduro" },
                    { "402dc189-ccf9-45e9-a8d4-61c32245efd4", null, "Felipa Anabel Maduro" },
                    { "41899b52-142d-43bf-b63c-083be606e6a3", null, "Alvaro Rick Sarmiento" },
                    { "42453d56-aa03-4cfc-b47d-15a9868c53e9", null, "Donald Nicomedes Herrera" },
                    { "43a1def7-a066-4599-9ddf-5fc260655500", null, "Donald Rick Ruiz" },
                    { "44c10fd4-4977-4c00-9a93-9223bf0076f8", null, "Alvaro Diomedes Uribe" },
                    { "44f95290-b535-4f89-b80a-5f0af1b8d58c", null, "Farid Murty Sarmiento" },
                    { "4668dae6-5d71-4faa-b6c0-1296b5ef8fe2", null, "Farid Rick Sarmiento" },
                    { "46c094d4-0777-44e4-b3d9-1e8b7a483689", null, "Felipa Nicomedes Herrera" },
                    { "47e3fd17-03ca-481b-a5b5-29b193096b02", null, "Alvaro Rick Trump" },
                    { "483fa752-4173-4f6d-908e-e6478b8b2b03", null, "Alba Teodoro Trump" },
                    { "485f68e1-7fec-49d3-88ca-4e4760892ae6", null, "Farid Freddy Sarmiento" },
                    { "493bbc62-bd30-4c24-bd59-c8341bf48e69", null, "Eusebio Rick Trump" },
                    { "49854558-45a2-4058-8237-f5065f4bbd44", null, "Alba Murty Uribe" },
                    { "4a026950-c64f-4b2e-a38c-38fb8f3b5bce", null, "Alba Teodoro Sarmiento" },
                    { "4a05f0ae-127b-4e67-b50c-0ceb35191f36", null, "Farid Anabel Herrera" },
                    { "4a2f4b5a-ad86-4c46-a265-4d0ebd548dbc", null, "Donald Nicomedes Sarmiento" },
                    { "4a83bd48-ea81-451f-a3da-facc9306e939", null, "Donald Silvana Ruiz" },
                    { "4a9ab81b-3dd4-43c9-9b92-39062e9b54bd", null, "Alvaro Murty Maduro" },
                    { "4bbfac8f-b1a3-4f27-a58d-98b02332d80a", null, "Alvaro Freddy Uribe" },
                    { "4c3c225c-83ac-4c95-9563-5676750d407a", null, "Nicolás Murty Herrera" },
                    { "4cb7e243-86c0-441c-bd04-a6f843eab956", null, "Eusebio Rick Ruiz" }
                });

            migrationBuilder.InsertData(
                table: "Alumnos",
                columns: new[] { "Id", "CursoId", "Nombre" },
                values: new object[,]
                {
                    { "4de1fa34-d89a-49e4-a45b-ed1bc1ef51de", null, "Alba Nicomedes Ruiz" },
                    { "4e099933-00f9-4ebd-be68-1930fb484f0f", null, "Donald Anabel Sarmiento" },
                    { "4f91581c-4e07-4be4-b6bd-1ce60796b3fe", null, "Eusebio Freddy Sarmiento" },
                    { "50806ad9-b95b-4c7b-81e2-10197c2dc663", null, "Donald Rick Uribe" },
                    { "51707cd6-6c8b-455e-882e-771c4b50ea40", null, "Felipa Nicomedes Ruiz" },
                    { "52df7e09-1d48-4074-8dcd-46e3782258df", null, "Alba Murty Maduro" },
                    { "54395b34-e144-4931-a4ad-5f35fca8da50", null, "Eusebio Nicomedes Toledo" },
                    { "5671e585-b3fe-4191-a1ef-62bf07e450c6", null, "Felipa Freddy Herrera" },
                    { "56f0fe5c-fe2b-4f5c-a89a-460eb0f50821", null, "Felipa Nicomedes Sarmiento" },
                    { "574b25d9-6924-4452-8ab4-d77dd8cb956d", null, "Alvaro Murty Herrera" },
                    { "57aacb3d-6184-45e7-9739-bf904d2443cf", null, "Alba Diomedes Trump" },
                    { "57d80341-6ccb-43ca-ae6d-b86736a2fc04", null, "Farid Anabel Maduro" },
                    { "58451afc-78bd-4463-b786-a526b2c4e396", null, "Alvaro Nicomedes Uribe" },
                    { "584f10bb-bc3c-45c8-aef4-4c72bb7a665c", null, "Eusebio Rick Uribe" },
                    { "585e3f17-bc82-4c98-9c48-048bf8cb7fb3", null, "Farid Nicomedes Herrera" },
                    { "5881c211-a120-469c-9acf-bc0cd21198b2", null, "Nicolás Rick Uribe" },
                    { "588338f8-5e14-4c0b-9f08-df9dd672a16f", null, "Felipa Teodoro Uribe" },
                    { "58fcad1a-1828-4383-8c44-d68f181fc5a3", null, "Nicolás Anabel Trump" },
                    { "59963058-ad50-405f-8f41-f022a8cfd4b5", null, "Donald Rick Herrera" },
                    { "59bea895-ab0c-4105-b766-df9a220ebc1b", null, "Eusebio Diomedes Uribe" },
                    { "59e95402-9029-44c6-b57e-0dca39712fd6", null, "Nicolás Silvana Toledo" },
                    { "5aab94cb-1c48-46ee-a111-f736a0dac3cb", null, "Alvaro Teodoro Toledo" },
                    { "5ae46881-1fe8-4ca7-957a-06519d4a585b", null, "Donald Murty Toledo" },
                    { "5af19ffc-bf4c-483a-ba87-993169cc235c", null, "Eusebio Nicomedes Uribe" },
                    { "5c022454-7027-45a8-9ead-9e32116d95d3", null, "Nicolás Silvana Trump" },
                    { "5cbefc1d-37c3-4932-9d32-5fbf2e9aad86", null, "Felipa Freddy Maduro" },
                    { "5d2eeae4-e8e1-4956-ac92-a633d27d384b", null, "Farid Diomedes Ruiz" },
                    { "5d3f078e-d904-452d-b40e-193c08223746", null, "Donald Silvana Trump" },
                    { "5fa44cc6-4220-4923-9db7-59e918aac018", null, "Alvaro Nicomedes Sarmiento" },
                    { "5fc32c09-fbfe-4e67-9724-8181e2d548c7", null, "Nicolás Freddy Herrera" },
                    { "60c48e98-59b3-4d3c-8bbc-8f2306f27d31", null, "Farid Silvana Uribe" },
                    { "60d51fb8-d6a2-4cf6-ac5c-be58d33d3a04", null, "Nicolás Anabel Toledo" },
                    { "638ecc30-a7b0-4223-b66f-7e98b4599805", null, "Nicolás Nicomedes Uribe" },
                    { "6393074a-5889-499c-b0be-764f1b9a9092", null, "Donald Teodoro Herrera" },
                    { "63d14665-7d7b-4da8-9249-b01d8f12f3e8", null, "Farid Anabel Trump" },
                    { "6403c04c-f37d-4a04-80cb-f939260b3964", null, "Nicolás Teodoro Trump" },
                    { "641fae4d-90bb-4487-b624-32fee3939dcc", null, "Felipa Murty Herrera" },
                    { "659357d5-0a55-4a51-93f9-af84688f70da", null, "Felipa Diomedes Uribe" },
                    { "65b2dc5f-82e5-4506-895d-db5ffd61c31b", null, "Alba Nicomedes Toledo" },
                    { "664e578a-47ad-4d58-b299-d3eba4c3f28f", null, "Alvaro Diomedes Trump" },
                    { "66bc1933-5ac3-4c51-93ec-bb88ab87d1c0", null, "Donald Rick Maduro" },
                    { "67279a92-4de6-4083-9904-8e3b53a6030c", null, "Alvaro Anabel Ruiz" }
                });

            migrationBuilder.InsertData(
                table: "Alumnos",
                columns: new[] { "Id", "CursoId", "Nombre" },
                values: new object[,]
                {
                    { "698e8a50-fb88-419a-a5db-9b317ccfe6d2", null, "Alba Anabel Ruiz" },
                    { "69b1b110-6d25-47db-be5a-24f208c825cd", null, "Nicolás Diomedes Sarmiento" },
                    { "69e6d0fa-bb2e-43a7-9626-f4a6d7ebdbbb", null, "Eusebio Teodoro Sarmiento" },
                    { "6c7e1b43-09aa-48fd-ad3e-879129fa3ead", null, "Alvaro Freddy Trump" },
                    { "6d62fc65-3467-4125-ac2d-1a37bb33808e", null, "Farid Diomedes Sarmiento" },
                    { "6db0b4fd-28b3-451d-bd72-cd4acaf0c7fa", null, "Nicolás Rick Ruiz" },
                    { "6e2b5a1d-3f12-4656-a8bb-4e849f2b9dc6", null, "Nicolás Silvana Ruiz" },
                    { "6f14d4f4-018b-4242-b7d9-73e6cea1326b", null, "Alvaro Freddy Ruiz" },
                    { "6f4afddd-1e17-4877-8fed-1c1fd4ddf46c", null, "Alvaro Rick Toledo" },
                    { "6f7a7972-a430-4a05-9bf4-c70b6b2a7308", null, "Felipa Rick Sarmiento" },
                    { "70da6c09-52c4-4b2f-a045-4b31dba1fe1c", null, "Nicolás Diomedes Herrera" },
                    { "714cc615-992b-492d-8a37-976378068a00", null, "Alvaro Murty Toledo" },
                    { "71b08e69-f468-4829-ad77-ed5398238bc6", null, "Felipa Teodoro Sarmiento" },
                    { "721febcc-1ff4-42db-bbf4-26ed85263222", null, "Eusebio Anabel Ruiz" },
                    { "7281e828-281d-470b-aede-6a85c67ec624", null, "Farid Diomedes Uribe" },
                    { "73acc3f2-ee4e-4298-8121-607f8568ab06", null, "Farid Teodoro Uribe" },
                    { "744f753a-2099-475a-87d8-84732e1a9123", null, "Farid Diomedes Maduro" },
                    { "763c02cd-20bb-4f17-ab23-801470e197d8", null, "Eusebio Silvana Uribe" },
                    { "769f0de9-8eff-43cf-b57c-5fecc347591c", null, "Alba Murty Herrera" },
                    { "77b96a5a-3573-4c9d-b375-f6918b6a8758", null, "Alba Freddy Trump" },
                    { "77dcea3e-7c6b-4f41-a768-1fc91b448e5f", null, "Nicolás Anabel Maduro" },
                    { "79b350af-b41c-408d-bf4b-1ccbd5b8b926", null, "Alvaro Nicomedes Maduro" },
                    { "79cc71df-fc42-4d23-974d-e650074c9fb8", null, "Eusebio Diomedes Herrera" },
                    { "7a563d7f-7941-4d28-ac7f-c352f25e7b73", null, "Alba Anabel Uribe" },
                    { "7a82b92d-e346-44eb-a88c-c7988fde2890", null, "Donald Freddy Ruiz" },
                    { "7b47870d-f0b4-47ec-93a6-eba29f30a273", null, "Alvaro Freddy Herrera" },
                    { "7b7e6fc4-8876-4df4-af2e-9c7e7a38afe9", null, "Alba Nicomedes Trump" },
                    { "7c091dee-9957-4e81-bbd7-257078268ccb", null, "Felipa Rick Uribe" },
                    { "7d24014b-89e1-45cc-bbc8-2f2fbfba6066", null, "Alvaro Teodoro Ruiz" },
                    { "7df22418-707f-42cf-8c21-a560f334d1b9", null, "Felipa Rick Herrera" },
                    { "7e23fb36-bc8c-4d86-9951-af9ae29a4062", null, "Felipa Anabel Trump" },
                    { "7e47cdde-11f4-4928-b51a-36a897eb694d", null, "Nicolás Murty Trump" },
                    { "80867e44-fb75-47be-a196-035f5a72d6aa", null, "Farid Teodoro Herrera" },
                    { "81139551-e4e8-41ea-b197-c053ce69db41", null, "Farid Nicomedes Sarmiento" },
                    { "819c8880-f02c-436a-be01-44e6626fb21a", null, "Eusebio Freddy Toledo" },
                    { "82dbc3d4-ea0c-452b-b89a-fdc43bff76b7", null, "Alvaro Silvana Herrera" },
                    { "8328025f-9775-47b4-988f-f9f9bd7a9189", null, "Donald Silvana Toledo" },
                    { "834a0fe3-6928-4598-8fed-b4438e8bf907", null, "Donald Teodoro Toledo" },
                    { "8398ebcd-371e-4561-9371-a5b1d471cf47", null, "Alba Teodoro Toledo" },
                    { "848e423a-fc52-4f97-80fa-51feecde7467", null, "Felipa Freddy Ruiz" },
                    { "8519f6ea-8bec-49fc-acb6-80f77792c83f", null, "Nicolás Teodoro Uribe" },
                    { "85482bac-6eae-48ca-9eb2-210c79773dcd", null, "Alvaro Nicomedes Toledo" }
                });

            migrationBuilder.InsertData(
                table: "Alumnos",
                columns: new[] { "Id", "CursoId", "Nombre" },
                values: new object[,]
                {
                    { "854e9e0c-c7cd-490a-81cb-b0986e3762c6", null, "Farid Rick Uribe" },
                    { "85a0be86-9dd6-4a91-adf5-8878a56b8966", null, "Farid Freddy Toledo" },
                    { "8672c4d0-d0d2-4958-9906-3a3f764ce76f", null, "Eusebio Diomedes Ruiz" },
                    { "8686e4af-e3ac-4c01-9ff9-a2b0ac9a79db", null, "Alba Rick Toledo" },
                    { "88c47012-f04a-497e-9ff4-5e83df12a258", null, "Felipa Diomedes Toledo" },
                    { "8ac5f4bf-9069-4358-849a-02701449964e", null, "Farid Diomedes Toledo" },
                    { "8ae663db-aac1-47c4-a1ba-5ddc628838ff", null, "Nicolás Anabel Ruiz" },
                    { "8b023d5e-2e80-4b64-ae0d-2cba245b31d2", null, "Farid Murty Herrera" },
                    { "8b411fd7-ca9d-47e7-95b2-d620f379ec86", null, "Donald Diomedes Ruiz" },
                    { "8ba31376-4b05-42c6-af59-5d9566c07309", null, "Alba Teodoro Maduro" },
                    { "8bac6ea2-1b35-4af0-9bba-7ec6512e35d6", null, "Nicolás Anabel Herrera" },
                    { "8d102003-0e0f-4447-92d0-04dcc797f848", null, "Alvaro Teodoro Trump" },
                    { "8d130951-4290-4287-b28e-d170e562a451", null, "Nicolás Diomedes Uribe" },
                    { "8d8adcf5-c142-4fa3-96cc-143e0aea5aae", null, "Eusebio Silvana Maduro" },
                    { "8d98f7b2-2729-4375-807e-1065d1fdfc7e", null, "Donald Silvana Uribe" },
                    { "8db2c21c-0b5d-475a-b8df-c2e09b223fac", null, "Felipa Anabel Uribe" },
                    { "8e3e9b12-b0bb-4d62-8e45-fc45c7021386", null, "Donald Anabel Herrera" },
                    { "8ec894e2-69ce-45fe-a339-3ca3c9ce38bf", null, "Felipa Rick Ruiz" },
                    { "8ef8c220-ec7d-4af4-ba08-799e8eae6735", null, "Donald Diomedes Maduro" },
                    { "9031e096-61a7-458b-96f5-429811ea43cf", null, "Donald Freddy Uribe" },
                    { "90529b22-ccdf-4ff3-bfd9-378bf164bd94", null, "Donald Anabel Maduro" },
                    { "90e76397-5cd9-4178-b332-803936258d1d", null, "Donald Freddy Herrera" },
                    { "914a6b1a-540b-4ba5-9c62-1e9afdae5fe3", null, "Alba Anabel Sarmiento" },
                    { "91b1e4e3-bcb8-475f-b6e7-d50814cc9d5d", null, "Farid Murty Trump" },
                    { "927a358c-890e-425f-afbf-a0c25f69d68c", null, "Nicolás Freddy Trump" },
                    { "928c0f38-aa11-4439-a33c-057ba4e28133", null, "Eusebio Teodoro Uribe" },
                    { "9345c1c9-d462-430e-ae57-a11fa1ad1858", null, "Alba Nicomedes Sarmiento" },
                    { "9526a5c6-3b77-437a-86e9-2ee1c5b353fd", null, "Alba Silvana Herrera" },
                    { "9551175d-df58-4741-98ac-58ac409446ab", null, "Donald Diomedes Sarmiento" },
                    { "95cac5ae-d16f-4043-9362-db43d3610688", null, "Donald Nicomedes Trump" },
                    { "96cfa176-1126-4fdc-ad2e-8f49f8243b95", null, "Alba Rick Uribe" },
                    { "970daa3e-9268-4894-8bbc-ec16c8c06d8b", null, "Eusebio Silvana Herrera" },
                    { "974547a9-7dd8-4988-8500-35f5d3e71eca", null, "Farid Nicomedes Ruiz" },
                    { "984f2797-298a-474e-a9b1-f83014588e90", null, "Felipa Diomedes Ruiz" },
                    { "98f434e7-d359-4930-aa61-be54919ab649", null, "Alba Silvana Ruiz" },
                    { "9926b28c-53b2-4fd4-9fa7-171834ddf597", null, "Nicolás Nicomedes Maduro" },
                    { "9a4d4395-97a8-4e2e-a1ef-4410059b6e77", null, "Alba Teodoro Uribe" },
                    { "9b473f68-44fd-41f2-97bb-ef5a9049baa6", null, "Alba Nicomedes Maduro" },
                    { "9b7617e9-6d25-41f4-a028-f218adc487c6", null, "Alvaro Silvana Uribe" },
                    { "9b91f947-f594-4278-b2b3-ac4104fe81d8", null, "Eusebio Teodoro Maduro" },
                    { "9c520b31-bfa7-411b-aca3-10a56f828579", null, "Farid Rick Ruiz" },
                    { "9c5eb086-4e15-403d-b5a9-e8d8041e0f11", null, "Nicolás Diomedes Ruiz" }
                });

            migrationBuilder.InsertData(
                table: "Alumnos",
                columns: new[] { "Id", "CursoId", "Nombre" },
                values: new object[,]
                {
                    { "9cf9ee31-1e48-4f45-823d-8f4d7ef966de", null, "Donald Diomedes Herrera" },
                    { "9d71cc6e-d104-4c9b-9293-666b97a5c8de", null, "Felipa Anabel Ruiz" },
                    { "9da2fc1c-6c90-4d14-b1ac-2078f3cb4530", null, "Eusebio Murty Herrera" },
                    { "9dc520a3-252b-446a-b6c5-cb6200506fb3", null, "Alba Anabel Maduro" },
                    { "9e677d8a-b57b-498e-a62e-d03048d0c676", null, "Eusebio Silvana Ruiz" },
                    { "9f5846a7-8f75-4d47-8591-e1809ee49c7f", null, "Nicolás Nicomedes Sarmiento" },
                    { "a0a7a2af-1f67-4ecf-82b4-fc08f2f28183", null, "Donald Rick Sarmiento" },
                    { "a18995ed-44ba-43f6-9f56-3a9ea5515ba0", null, "Eusebio Silvana Trump" },
                    { "a1d1a2ca-0f06-468e-823e-95442e2bd698", null, "Alvaro Freddy Toledo" },
                    { "a24b680e-31ef-4a34-8d16-ce5fe220d727", null, "Eusebio Anabel Toledo" },
                    { "a309ceda-9264-4a84-8a32-7251269fbeca", null, "Felipa Diomedes Sarmiento" },
                    { "a3e2a4f7-ccbf-4c2d-af3d-27c6b74bc6be", null, "Alvaro Silvana Toledo" },
                    { "a567a5ec-bff4-4ba8-a292-261a765c3ecb", null, "Felipa Anabel Sarmiento" },
                    { "a627f769-08a3-4334-b40b-85ef17685e6e", null, "Felipa Murty Toledo" },
                    { "a81c32a3-6e0a-41ad-b800-da898f0ee92a", null, "Felipa Nicomedes Uribe" },
                    { "aa8ebb9b-31df-4c69-a0e9-75b1b8ba9720", null, "Alvaro Diomedes Sarmiento" },
                    { "aabf502f-98f8-421d-8737-0e5f36dc6e05", null, "Alba Freddy Uribe" },
                    { "ab5f980d-9366-4bbc-a679-f9fb7d7b4a98", null, "Nicolás Teodoro Toledo" },
                    { "aba7fda5-d957-4024-87c7-34d079fac0c3", null, "Eusebio Freddy Ruiz" },
                    { "abcde778-eb6d-41ec-b6fb-a1f39ab4266c", null, "Nicolás Silvana Sarmiento" },
                    { "aca84c35-721a-4590-a236-b3a9291d9076", null, "Nicolás Diomedes Trump" },
                    { "acbf74fe-388d-4516-b297-d9bbe64ad308", null, "Farid Nicomedes Trump" },
                    { "acd9272e-611c-4da5-8cfe-2bb2961880c5", null, "Donald Diomedes Uribe" },
                    { "ad7197bf-3c99-4d76-9b4a-391e7cfec85d", null, "Alba Silvana Uribe" },
                    { "ae79ceed-6338-480f-95cc-ab2bbfe0f31a", null, "Farid Rick Trump" },
                    { "aed310a2-51bd-49c9-8b95-742f20c8b0ca", null, "Farid Murty Uribe" },
                    { "af29c053-2e83-40f1-86b2-394e7b29a659", null, "Farid Silvana Toledo" },
                    { "af3d069b-61c6-416e-b732-acabe7e10dfd", null, "Donald Freddy Maduro" },
                    { "b061fe8d-f522-46f8-a4b5-542f3ac96819", null, "Alba Teodoro Herrera" },
                    { "b09946e9-80ac-44fa-b23e-7774df544eaf", null, "Eusebio Teodoro Trump" },
                    { "b0f14ae8-1426-4eb2-b905-3922177d19a5", null, "Nicolás Diomedes Maduro" },
                    { "b1197635-bf27-4577-baaa-10119d1790e9", null, "Donald Diomedes Trump" },
                    { "b11a545d-09e2-475a-8bea-3b032e521c6c", null, "Alvaro Murty Sarmiento" },
                    { "b28d537d-c8ae-44fe-b233-38d332ad9772", null, "Donald Nicomedes Maduro" },
                    { "b39358d1-c4ea-461a-bfee-b86543e8bde5", null, "Alvaro Anabel Herrera" },
                    { "b5689d28-d60f-46de-a27b-8c3c5d2cf869", null, "Eusebio Rick Toledo" },
                    { "b5e7d607-a185-4665-b46e-efb3e81b51f5", null, "Eusebio Freddy Trump" },
                    { "b6223971-8f95-49af-abdc-9f58abc43fa5", null, "Nicolás Rick Trump" },
                    { "b637fc67-d3c2-4fa6-86e0-5d82cb0148df", null, "Eusebio Diomedes Trump" },
                    { "b7446db6-5f76-4d95-8796-f234f44ba0f2", null, "Alvaro Silvana Ruiz" },
                    { "b74df0d6-fcf9-40d9-9b67-49261d210e37", null, "Alba Silvana Maduro" },
                    { "b7a32d86-9ebc-4730-ab26-d2a85194ed52", null, "Felipa Murty Maduro" }
                });

            migrationBuilder.InsertData(
                table: "Alumnos",
                columns: new[] { "Id", "CursoId", "Nombre" },
                values: new object[,]
                {
                    { "b8c0635a-7ca4-4102-a858-240ed2e6da08", null, "Farid Anabel Ruiz" },
                    { "b93b433e-87f1-4d6f-9773-2dd7c34743e7", null, "Felipa Diomedes Maduro" },
                    { "b9565db2-01fa-4f7a-b399-d1fa571b8319", null, "Eusebio Freddy Uribe" },
                    { "bafd2c7a-0c76-45ab-901d-eaed2f62c7f4", null, "Felipa Teodoro Ruiz" },
                    { "bdb03449-2ce7-4474-9d4b-4666b8b6dd0f", null, "Eusebio Diomedes Sarmiento" },
                    { "be258f9c-2ebe-42bc-9c3f-f8975581a7e1", null, "Eusebio Murty Uribe" },
                    { "bf38858f-aead-41f5-93fa-b65937054743", null, "Eusebio Nicomedes Maduro" },
                    { "bfbc7563-afa8-4f80-96b5-3295c53c328f", null, "Nicolás Anabel Uribe" },
                    { "c124bc1a-3bac-436f-89f2-fdb5d8ce3609", null, "Alba Rick Ruiz" },
                    { "c3acab91-e6d6-4220-a92e-cf276d44fa5b", null, "Nicolás Anabel Sarmiento" },
                    { "c3bd216b-dfa1-479a-809e-e19694d3c868", null, "Alba Diomedes Toledo" },
                    { "c69aacfe-dacf-4a26-acac-f997e1fcec86", null, "Nicolás Diomedes Toledo" },
                    { "c74695e9-576d-4021-8731-020f40f5f0e3", null, "Nicolás Silvana Maduro" },
                    { "c85d1bd0-46dc-49c2-ad14-0f74f24b56fe", null, "Eusebio Anabel Maduro" },
                    { "c88802a3-7831-4df5-9cce-5c2b2cde3a8f", null, "Alba Silvana Trump" },
                    { "c94ec83f-b259-40f5-b876-e8aaeec1b166", null, "Eusebio Nicomedes Herrera" },
                    { "c9b7876c-93df-4a9d-902f-bfbba3249dd1", null, "Alba Diomedes Herrera" },
                    { "ca8b0bf9-e3cd-4ac0-b0e7-f1016ca0a727", null, "Eusebio Freddy Herrera" },
                    { "cadc1597-4086-4132-b96d-6f7be2c5a7fe", null, "Alvaro Freddy Sarmiento" },
                    { "caf6e1d5-c658-4c11-ac7d-6c57c69f1977", null, "Nicolás Murty Uribe" },
                    { "cb41a8a5-df0d-4695-9a08-588d38a42a39", null, "Alba Freddy Herrera" },
                    { "cba95312-0215-4b75-9e01-c3c538205bb1", null, "Alvaro Teodoro Maduro" },
                    { "cc1f39d0-992b-4fd4-b8b3-324d8cbc49eb", null, "Donald Nicomedes Ruiz" },
                    { "cc338d66-37a6-4a47-91aa-32240958cf6a", null, "Alvaro Teodoro Uribe" },
                    { "cc47c5a8-dec1-4a56-88af-a127b1476b58", null, "Nicolás Rick Herrera" },
                    { "cd835ee5-5ac8-4d51-b020-bbb1e169acd4", null, "Farid Nicomedes Maduro" },
                    { "cdbee9e0-ecb0-441e-b97a-f6acede12492", null, "Donald Anabel Ruiz" },
                    { "cdd10cad-02ba-4626-b037-2e18ec4549ac", null, "Donald Anabel Trump" },
                    { "cdd12a5f-7477-4c6f-b3b7-32e7cf5cefd0", null, "Donald Nicomedes Uribe" },
                    { "cf82b975-3f8b-40b4-9ddf-057f16f0abb2", null, "Felipa Freddy Trump" },
                    { "d1f3f997-6581-471e-80eb-99b17a149fd8", null, "Donald Murty Maduro" },
                    { "d30f12f5-4c28-4020-9f02-7e2185b9993d", null, "Alba Diomedes Maduro" },
                    { "d3124699-b8a8-42b4-afd2-66a64f60e59e", null, "Nicolás Freddy Sarmiento" },
                    { "d3d5bd0b-8ad9-45a2-8a66-fb068625a193", null, "Alvaro Diomedes Ruiz" },
                    { "d421d228-f6ab-4c33-b2c5-4bf0e23ff74c", null, "Alvaro Silvana Trump" },
                    { "d43b1a7a-b45b-4503-b9b7-8238dc5e5e33", null, "Felipa Murty Uribe" },
                    { "d4559d36-536e-48ca-857f-133a9320c61c", null, "Alvaro Rick Ruiz" },
                    { "d477c5dc-5c93-485d-bb0a-d1097f002a0c", null, "Donald Freddy Trump" },
                    { "d4a4d6c1-9e30-4a4b-b91d-e5427278737a", null, "Alba Rick Maduro" },
                    { "d4de7946-96e2-4421-8ea8-617cb0a82d29", null, "Eusebio Rick Sarmiento" },
                    { "d58279d7-66bd-4819-8489-da13a35c0ec4", null, "Nicolás Freddy Ruiz" },
                    { "d5d7aa0d-6e74-476e-82ab-168a2e3f22b6", null, "Felipa Nicomedes Toledo" }
                });

            migrationBuilder.InsertData(
                table: "Alumnos",
                columns: new[] { "Id", "CursoId", "Nombre" },
                values: new object[,]
                {
                    { "d5dcd568-8ef2-4bad-9060-82481ed35646", null, "Felipa Diomedes Herrera" },
                    { "d6155f04-03f1-4028-906f-f91622d7df99", null, "Alba Rick Herrera" },
                    { "d66cebe9-b387-497e-aea1-c5e1ac40350b", null, "Nicolás Murty Ruiz" },
                    { "d6c12662-d261-47d8-a888-54493544cfb6", null, "Felipa Teodoro Trump" },
                    { "d7479b60-8084-4425-95da-672669bd8870", null, "Donald Anabel Uribe" },
                    { "d757323e-2458-46c2-9224-1a5b5dcd9ebf", null, "Farid Diomedes Trump" },
                    { "d88755e5-183c-415f-a5fd-d80bf73903aa", null, "Donald Anabel Toledo" },
                    { "da863279-512f-4519-bc31-0631784bbbe8", null, "Felipa Rick Maduro" },
                    { "dbc2bdda-f560-4c6e-a174-194e1156e1b0", null, "Nicolás Rick Toledo" },
                    { "dc43254f-d719-4bed-9cca-38e2e6ef4202", null, "Nicolás Nicomedes Toledo" },
                    { "df08a3ae-1a9a-469d-8ffd-a7e9130127b4", null, "Alba Silvana Toledo" },
                    { "e04c101d-158a-4d18-9b14-f2be998f89ec", null, "Donald Murty Uribe" },
                    { "e0c907b4-5439-4f72-8856-c41c9cd4d416", null, "Farid Freddy Herrera" },
                    { "e0eeeb02-f794-40a5-994c-92afa06d34f6", null, "Donald Teodoro Trump" },
                    { "e2d6c002-18ee-44eb-a880-645d19c6b632", null, "Eusebio Silvana Toledo" },
                    { "e38825c9-5938-4147-9eec-b55c91558cd1", null, "Eusebio Rick Maduro" },
                    { "e3da6055-667b-4695-9d69-771a8c4247c8", null, "Farid Freddy Trump" },
                    { "e43999a1-5ec4-4e62-8152-8711a2b42600", null, "Felipa Teodoro Herrera" },
                    { "e642effe-7e58-402f-bed4-8fbd8f4d2a33", null, "Alba Silvana Sarmiento" },
                    { "e66099fc-5735-4f91-ad40-3fcdb9c1ae78", null, "Nicolás Rick Sarmiento" },
                    { "e88e4c1b-6137-4a6a-b4dd-a0c546176796", null, "Felipa Silvana Uribe" },
                    { "e8be7230-899a-475b-a5c8-e5c075d836f6", null, "Alvaro Nicomedes Herrera" },
                    { "e8d4a20b-f3ea-4174-940a-bcada0fb7d64", null, "Nicolás Teodoro Sarmiento" },
                    { "e8d54bc7-f306-4961-9ad0-fcf090c6b077", null, "Alvaro Teodoro Herrera" },
                    { "e971100e-bbf6-4f5f-8800-2e02965ac753", null, "Farid Teodoro Sarmiento" },
                    { "e9955902-edaf-475b-b206-dfd03091419e", null, "Eusebio Teodoro Toledo" },
                    { "ea9dd874-abca-4311-97cf-ae3cbcb324eb", null, "Donald Freddy Toledo" },
                    { "eb22fad9-341d-4aa7-b856-45dfd0721d35", null, "Alvaro Nicomedes Ruiz" },
                    { "eb965849-778d-4b88-98c6-68d3eabda950", null, "Eusebio Nicomedes Ruiz" },
                    { "ec73edca-97a7-4f33-a4ed-5c39e7b67481", null, "Eusebio Anabel Sarmiento" },
                    { "ee67f156-1bcd-40a4-8514-75e9e09ea7e1", null, "Alba Nicomedes Herrera" },
                    { "efd72e3d-32f9-40c1-b0d3-aa2d237a172a", null, "Alba Diomedes Ruiz" },
                    { "efe486df-b7c4-48d0-90d2-9177221e802e", null, "Felipa Silvana Sarmiento" },
                    { "f0b14e53-3948-4453-8506-7c8590593de4", null, "Eusebio Murty Trump" },
                    { "f1e88cf6-787b-4794-a7be-4ed5363f6f4a", null, "Alvaro Freddy Maduro" },
                    { "f209a4c4-753f-420f-8efb-8a6f3f73f962", null, "Felipa Teodoro Maduro" },
                    { "f26fad02-0da0-414b-bc89-107db4927e19", null, "Farid Diomedes Herrera" },
                    { "f3619a48-e848-461d-8749-fc3d6795dead", null, "Donald Murty Ruiz" },
                    { "f4003e1c-2f7f-484c-90ff-42993010a33c", null, "Donald Diomedes Toledo" },
                    { "f51ccecb-d225-4ff7-b122-6248a8804c38", null, "Alvaro Anabel Toledo" },
                    { "f53344ea-05b9-41c5-bd5c-42ec2375ad63", null, "Alvaro Anabel Trump" },
                    { "f5695459-ce39-4e6a-baaa-d1b2470bf023", null, "Nicolás Freddy Uribe" }
                });

            migrationBuilder.InsertData(
                table: "Alumnos",
                columns: new[] { "Id", "CursoId", "Nombre" },
                values: new object[,]
                {
                    { "f6c9025f-e206-429a-8cb6-35a90813e5c9", null, "Farid Murty Toledo" },
                    { "f8168d56-c5f5-473d-9905-00aa53c53d4c", null, "Nicolás Silvana Uribe" },
                    { "f8893c43-0086-415d-94eb-7ebd3335a018", null, "Donald Silvana Sarmiento" },
                    { "fa11c1e5-2984-48b4-ad1b-0cd76c5feea6", null, "Eusebio Teodoro Ruiz" },
                    { "fb29e2c4-d305-48e9-8c3b-3dc07eacceaa", null, "Farid Murty Ruiz" },
                    { "fb8f3c7a-6de8-4082-9b11-927f64c3f314", null, "Eusebio Teodoro Herrera" },
                    { "fb947eca-3049-4519-b1ee-c492932b7515", null, "Farid Anabel Toledo" },
                    { "fbdef0d7-6247-4784-8adc-c9093bf36d52", null, "Farid Silvana Herrera" },
                    { "fcca12af-62b7-4d61-9592-f71073650186", null, "Felipa Nicomedes Trump" },
                    { "fd002eda-8fa0-42e2-9c06-1faee9fda365", null, "Felipa Teodoro Toledo" },
                    { "fd680982-9fd9-4665-b86c-d85e69d3fd9a", null, "Farid Anabel Uribe" },
                    { "fdaebeac-5de5-4aee-bfeb-b683d7bc7f9e", null, "Eusebio Anabel Trump" },
                    { "fe4e6f0d-6a6f-417a-9cde-91c47ec37b46", null, "Alba Murty Trump" },
                    { "ff8e3b64-1c6b-4ca8-85a9-2f5fce8268a7", null, "Felipa Murty Sarmiento" }
                });

            migrationBuilder.InsertData(
                table: "Asignaturas",
                columns: new[] { "Id", "CursoId", "Nombre" },
                values: new object[,]
                {
                    { "1f33e0c5-3bc8-4629-a406-bf89598515f9", null, "Educación Física" },
                    { "31feca3b-d741-4352-982b-d4d50f5940fd", null, "Programacion" },
                    { "53e84b02-cce4-4abf-b01a-ce9321ad9949", null, "Castellano" },
                    { "550c8665-bcdf-456b-9618-5fb81c492e13", null, "Ciencias Naturales" },
                    { "61221d7f-01ed-4713-a673-9ab59e058f4d", null, "Matemáticas" }
                });

            migrationBuilder.InsertData(
                table: "Escuelas",
                columns: new[] { "Id", "AñoDeCreación", "Ciudad", "Dirección", "Nombre", "Pais", "TipoEscuela" },
                values: new object[] { "e3f134cf-21d0-40ca-bcb2-7fde285717aa", 2005, " Bogota", " Avda siempre viva", " Platzi School", " Colombia", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Alumnos_CursoId",
                table: "Alumnos",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_Asignaturas_CursoId",
                table: "Asignaturas",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_Cursos_EscuelaId",
                table: "Cursos",
                column: "EscuelaId");

            migrationBuilder.CreateIndex(
                name: "IX_Evaluaciones_AlumnoId",
                table: "Evaluaciones",
                column: "AlumnoId");

            migrationBuilder.CreateIndex(
                name: "IX_Evaluaciones_AsignaturaId",
                table: "Evaluaciones",
                column: "AsignaturaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Evaluaciones");

            migrationBuilder.DropTable(
                name: "Alumnos");

            migrationBuilder.DropTable(
                name: "Asignaturas");

            migrationBuilder.DropTable(
                name: "Cursos");

            migrationBuilder.DropTable(
                name: "Escuelas");
        }
    }
}
