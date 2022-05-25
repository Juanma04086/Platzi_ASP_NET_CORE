using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Platzi_ASP_NET_CORE.Migrations
{
    public partial class Independent : Migration
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
                    { "015c7962-6591-4e49-b457-1a1f5f7e068a", null, "Alvaro Teodoro Maduro" },
                    { "023238ef-1123-47d8-9e91-4584927a18a3", null, "Felipa Anabel Herrera" },
                    { "025fb213-4d59-4708-85ea-524ce312ee54", null, "Eusebio Anabel Toledo" },
                    { "03776ef4-002b-482a-a4f0-bbcb6920532b", null, "Donald Murty Trump" },
                    { "03d505ca-b3c1-422b-a30f-066d7d22546c", null, "Donald Murty Uribe" },
                    { "03fa6242-2254-4709-bc19-1f7a6f5ff20b", null, "Donald Silvana Maduro" },
                    { "05de6954-45c4-41b5-9b3c-c7a9a4931fbc", null, "Nicolás Teodoro Ruiz" },
                    { "0664ecab-70e0-461c-95e6-23cea82793a2", null, "Alba Anabel Trump" },
                    { "07ac7b43-e251-48b8-b9b1-590e4f906e00", null, "Nicolás Freddy Ruiz" },
                    { "08225aca-65b7-429f-ab33-78e3d34d3111", null, "Donald Rick Sarmiento" },
                    { "09154555-639b-40a6-a6d8-cca401800ca0", null, "Felipa Nicomedes Ruiz" },
                    { "095585e4-a761-4b72-862e-21f612b9dd6b", null, "Eusebio Teodoro Toledo" },
                    { "096555da-8845-46f6-b24f-b81a7c7c3368", null, "Alvaro Freddy Herrera" },
                    { "0b0b9e12-0b8e-4de5-a6a0-6461f75a0fdd", null, "Farid Diomedes Uribe" },
                    { "0c2b537d-a7ad-49c1-9737-30c5260d78d5", null, "Felipa Freddy Maduro" },
                    { "0c91988d-885b-45fd-8b08-204a06a5cbf8", null, "Donald Diomedes Uribe" },
                    { "0cd68a69-5c5a-4b00-be1e-d0c4a3dc492b", null, "Alba Teodoro Ruiz" },
                    { "0d7b1ee4-9030-453e-aaba-4c362d7fa5e6", null, "Nicolás Anabel Ruiz" },
                    { "0f43b661-bac6-4980-97b6-79cd9a60c6e9", null, "Alvaro Anabel Maduro" },
                    { "103c1e1b-0d7c-49f1-9d19-25dd98aebd30", null, "Alvaro Anabel Trump" },
                    { "11070823-8fd2-4bf9-a1cc-c1f4a3e44988", null, "Felipa Nicomedes Trump" },
                    { "115378b1-cbb8-4b7f-a502-d76fa238c39a", null, "Alvaro Diomedes Trump" },
                    { "11a51493-c2d2-4ee1-87b9-545dc053cc19", null, "Farid Teodoro Uribe" },
                    { "12c058e0-8022-4f8e-9bb3-b037a5653aea", null, "Alba Diomedes Sarmiento" },
                    { "13aea6b8-1c2e-4aec-814c-ddd1582bfa42", null, "Eusebio Nicomedes Trump" },
                    { "13e79628-d046-4195-bb5d-7373ab27c2ff", null, "Donald Murty Toledo" },
                    { "13ece977-3aa9-4c04-b92e-9125927b7b5f", null, "Alvaro Freddy Toledo" },
                    { "146489a7-9e9c-4000-88ed-d1c968c871ea", null, "Alba Rick Herrera" },
                    { "151ff1a2-d57f-47d9-a00e-ba7e63af7b66", null, "Alba Teodoro Herrera" },
                    { "157664c8-abfc-426b-97da-4498b8fcf46b", null, "Felipa Silvana Uribe" },
                    { "1597a3a1-4e51-4410-bb33-3c5e168fce02", null, "Eusebio Rick Herrera" },
                    { "15b3d197-0172-43da-813a-dcbd5715f5fe", null, "Felipa Nicomedes Toledo" },
                    { "1610d00f-c73e-4a1d-a3d5-feece0aff9ed", null, "Nicolás Teodoro Herrera" },
                    { "162fe1ed-c541-46e2-bf38-7b97f5a2c7d1", null, "Donald Silvana Herrera" },
                    { "166c6393-6902-45a6-8ded-fa21ca7c1454", null, "Farid Teodoro Maduro" },
                    { "17b4489e-b80f-47b3-8113-ae33f480dd9c", null, "Farid Anabel Uribe" },
                    { "18d92516-3947-435b-811d-6ca537d80186", null, "Nicolás Anabel Herrera" },
                    { "18f6cd3c-eb5d-43b1-b733-49ef20a771c6", null, "Donald Teodoro Uribe" },
                    { "19405cbe-321c-44e1-9eb7-0fe9a6d0ba67", null, "Felipa Rick Herrera" },
                    { "19876991-95f7-456b-81c4-a3f1a6901fbb", null, "Eusebio Freddy Trump" },
                    { "1a63d308-fa56-4c30-9dec-1abd30dad2d7", null, "Farid Diomedes Trump" },
                    { "1b7ae0b4-4d07-4a37-83cd-e7b57e3909a9", null, "Alvaro Murty Herrera" }
                });

            migrationBuilder.InsertData(
                table: "Alumnos",
                columns: new[] { "Id", "CursoId", "Nombre" },
                values: new object[,]
                {
                    { "1df6e58a-aca6-44e5-bbd1-ca0418c5deab", null, "Farid Rick Uribe" },
                    { "1dfc9b83-fa47-4cbe-86ab-23703b638922", null, "Farid Rick Maduro" },
                    { "1e14ca5b-ace1-4cd1-9daf-7938868da466", null, "Felipa Teodoro Herrera" },
                    { "1eb67fac-fd6b-4648-8dd6-5011b0f9b142", null, "Alba Silvana Toledo" },
                    { "1ebee6f7-5a5a-44f5-9641-d74ad2289ccf", null, "Donald Teodoro Toledo" },
                    { "20aeffc3-39bc-4f71-aa43-fe80703afcbb", null, "Alba Murty Uribe" },
                    { "211048ab-4320-462e-8746-1cc06aa2be98", null, "Felipa Freddy Ruiz" },
                    { "227c6248-c534-4b17-b916-88cb2bdded53", null, "Nicolás Diomedes Toledo" },
                    { "2294ebfd-9bb6-4c36-8867-ee88bfa8f4af", null, "Alvaro Murty Toledo" },
                    { "22c580e8-cd23-412e-851b-e9805c454eda", null, "Alba Nicomedes Uribe" },
                    { "23aa4354-bc44-41a0-8b65-c814bb2e330f", null, "Alvaro Nicomedes Sarmiento" },
                    { "23afec87-ac1a-40b6-b0f9-fc09b9dbac82", null, "Felipa Teodoro Ruiz" },
                    { "2454ff88-7990-4cd0-af13-743057d7f18f", null, "Eusebio Anabel Trump" },
                    { "24bcf5f2-3099-407b-b962-66aad3c393b7", null, "Alba Nicomedes Toledo" },
                    { "2525a578-d2ca-4cf1-b20d-4228743eea06", null, "Felipa Murty Uribe" },
                    { "25bc77a9-912d-4ae4-9f6a-72c7e836dfde", null, "Alvaro Murty Sarmiento" },
                    { "25e52478-7f16-49de-a625-4f9d54774123", null, "Alba Rick Trump" },
                    { "26d0c42a-5bd0-4b82-80d9-955eb713c299", null, "Felipa Teodoro Toledo" },
                    { "277df777-e675-4486-b31d-5359c5db54d3", null, "Eusebio Freddy Herrera" },
                    { "281ddc1e-7646-462a-9a67-979796c3fd40", null, "Alvaro Rick Herrera" },
                    { "289a71a8-0b0b-4834-9b67-f0aeab61d7b4", null, "Donald Murty Maduro" },
                    { "2961d854-0bc5-4bfe-8ccd-e54e7d04127e", null, "Donald Murty Herrera" },
                    { "29ec22a5-5086-42f5-9bc9-8a5cfd65680e", null, "Nicolás Nicomedes Sarmiento" },
                    { "2a0d4b27-739a-4949-bc19-e9d59e3dfb02", null, "Felipa Silvana Maduro" },
                    { "2a9acfb9-1d2f-447f-8cd3-e69d6457ca43", null, "Nicolás Teodoro Toledo" },
                    { "2b23ba9b-6b36-412e-ac17-8a300dfff7d3", null, "Eusebio Nicomedes Ruiz" },
                    { "2b355598-81ec-463f-af35-c0b764a9fb67", null, "Alvaro Freddy Sarmiento" },
                    { "2be27117-c511-4ac2-b47f-414a2a23a69d", null, "Alvaro Anabel Ruiz" },
                    { "2d0bb076-ef04-4866-afd8-79ff632b08f8", null, "Alba Diomedes Toledo" },
                    { "2dcb46b4-6d33-469f-bce2-6dac601e07a8", null, "Alvaro Silvana Herrera" },
                    { "2f0bd781-2b92-4f67-837a-36dbf6afaf44", null, "Donald Anabel Herrera" },
                    { "2f5b6ca7-afed-452b-8792-5d338ec807d8", null, "Nicolás Rick Maduro" },
                    { "3044b1fb-ffc2-43d9-ad69-b9ced403db31", null, "Nicolás Silvana Trump" },
                    { "30959c42-6a2d-46a4-9395-6f43993e26f7", null, "Nicolás Diomedes Herrera" },
                    { "30e27def-8dde-41fd-97c1-f5f6c0f88799", null, "Donald Anabel Uribe" },
                    { "316dabdf-b059-489f-bda2-eb7a677c5d4e", null, "Felipa Murty Trump" },
                    { "31a4ef30-63e6-408e-bd9b-287178791ee0", null, "Felipa Silvana Sarmiento" },
                    { "31b238a6-7421-4719-a912-c98d42a35e16", null, "Donald Silvana Sarmiento" },
                    { "31bac215-239e-4552-b139-8b192a2b8327", null, "Eusebio Rick Toledo" },
                    { "32497399-0a7a-416b-89ed-eef5a813790e", null, "Nicolás Freddy Trump" },
                    { "3316d5ae-f3c7-4fe1-be68-021bc39473ed", null, "Eusebio Anabel Sarmiento" },
                    { "332c777b-24e2-4e5e-ae65-bff6010911c2", null, "Farid Diomedes Herrera" }
                });

            migrationBuilder.InsertData(
                table: "Alumnos",
                columns: new[] { "Id", "CursoId", "Nombre" },
                values: new object[,]
                {
                    { "33c38c0c-f3d0-4ca9-b9d8-29015425f8d1", null, "Donald Anabel Trump" },
                    { "3448d17e-b9f6-4774-9cdd-d452185c932d", null, "Farid Freddy Sarmiento" },
                    { "352e6411-2311-42df-b8b2-a617b1dfc7e0", null, "Eusebio Murty Herrera" },
                    { "35b9e25c-9d66-4853-b804-197131053fd5", null, "Alba Murty Maduro" },
                    { "38b3e7a7-0e90-4de8-84bd-a307ef87f21d", null, "Farid Murty Ruiz" },
                    { "3941921d-f1fa-4cc5-b6c3-4d92ca0cd8d5", null, "Alba Rick Maduro" },
                    { "396ab00e-7d0e-4428-93d3-89d1ae5433d0", null, "Alba Diomedes Uribe" },
                    { "3a0d85ed-780d-4208-bd87-05408ae2e848", null, "Farid Anabel Toledo" },
                    { "3a68f950-546c-44b4-9992-48ed6bd16da0", null, "Eusebio Diomedes Herrera" },
                    { "3b878dff-0e78-4950-8c99-db161f6ae942", null, "Eusebio Nicomedes Uribe" },
                    { "3be195aa-17d6-40de-bfdc-0654f308fab8", null, "Donald Rick Herrera" },
                    { "3d5777f7-a296-46cd-acd6-05a8ebd768ff", null, "Nicolás Silvana Toledo" },
                    { "3d5f460b-1470-43ba-a8bc-fd5e2cdd4528", null, "Alba Freddy Ruiz" },
                    { "3de62a18-4a88-44fc-a1da-93bfd8b8a21a", null, "Farid Teodoro Ruiz" },
                    { "3e602be8-b906-4bab-8a83-ea371baf5b99", null, "Alvaro Diomedes Sarmiento" },
                    { "3fa0dc1a-5779-43c6-96c1-b989ce90ffde", null, "Felipa Diomedes Maduro" },
                    { "408f204b-9c64-4d4a-a5e5-6f0d6babaec3", null, "Nicolás Nicomedes Uribe" },
                    { "4123c22b-9c1a-4d10-bca2-6916e5a3a5d1", null, "Alvaro Diomedes Toledo" },
                    { "422b207e-d4fa-4b70-9308-45aea28a9979", null, "Alba Silvana Sarmiento" },
                    { "4238204b-97b6-471f-90e0-77daeb9491f3", null, "Alvaro Diomedes Herrera" },
                    { "4384d377-6775-4f70-bef5-7f419a15a192", null, "Alvaro Nicomedes Trump" },
                    { "453820e2-9b8d-4348-a8db-3466c7ca2a6d", null, "Eusebio Silvana Trump" },
                    { "453a6e5a-df47-40b5-a22b-8e65480f1aa2", null, "Nicolás Silvana Sarmiento" },
                    { "45453ecc-ea86-42c5-9593-0f675cee5356", null, "Alvaro Nicomedes Ruiz" },
                    { "4643edad-880e-4523-b13f-ee5e02d8439c", null, "Farid Freddy Trump" },
                    { "465bf11a-86a9-4fbc-99cb-1449b983b46a", null, "Farid Silvana Herrera" },
                    { "470ef04d-13ac-4019-9883-b40711fab94a", null, "Donald Freddy Sarmiento" },
                    { "472662bb-795d-4ba7-96b3-852e3e34b769", null, "Nicolás Silvana Ruiz" },
                    { "475e226f-e45b-4851-9fdd-a22d0e6c2b21", null, "Eusebio Murty Sarmiento" },
                    { "48653702-2c0c-4c08-9506-5b2a409c6f6a", null, "Eusebio Diomedes Ruiz" },
                    { "49b662de-4f77-4be5-bee9-c2130df63da5", null, "Alba Nicomedes Herrera" },
                    { "4a4f31f9-d335-4c6e-8896-cd5c62f3163a", null, "Farid Murty Sarmiento" },
                    { "4ab26486-3823-42c0-ae98-02f3055518b2", null, "Donald Rick Ruiz" },
                    { "4b4b7f7e-c8f3-4bef-aa5f-acb5bacab040", null, "Alvaro Murty Ruiz" },
                    { "4b570d44-7041-447b-93b4-67cf08267389", null, "Eusebio Teodoro Uribe" },
                    { "4bb09d0b-b717-4845-986f-b296d28474b1", null, "Nicolás Anabel Maduro" },
                    { "4c63e942-3963-4f8b-aabe-b443fc73677a", null, "Felipa Rick Trump" },
                    { "4d875a50-2997-42f5-9c95-82455a77a21a", null, "Nicolás Anabel Toledo" },
                    { "4eec5c5a-7c12-4aac-a56f-94ff4f75f809", null, "Alba Murty Trump" },
                    { "52481276-5db7-4f85-a371-213c7e9b0143", null, "Donald Freddy Maduro" },
                    { "529f5289-697b-46ca-91f1-3d788a926caa", null, "Eusebio Teodoro Trump" },
                    { "52f913c4-0c2c-4ded-beac-33a365a9d401", null, "Donald Anabel Sarmiento" }
                });

            migrationBuilder.InsertData(
                table: "Alumnos",
                columns: new[] { "Id", "CursoId", "Nombre" },
                values: new object[,]
                {
                    { "5388a468-e659-4221-b71a-b16b9c88c352", null, "Nicolás Diomedes Sarmiento" },
                    { "53989a8e-3838-41c8-80be-c01185a15d89", null, "Donald Diomedes Herrera" },
                    { "53d44ebc-9493-431f-80a9-6c9e2e8fb035", null, "Nicolás Freddy Maduro" },
                    { "56252205-5a96-4ad1-961b-67f3e9274b87", null, "Donald Freddy Trump" },
                    { "56615db9-167c-4845-9132-eb90046a0939", null, "Nicolás Nicomedes Herrera" },
                    { "56c8bf5c-8079-4437-8ce6-43396b4c2802", null, "Alvaro Teodoro Uribe" },
                    { "57a5720f-9dd5-4638-b980-26dfabe56eec", null, "Alvaro Diomedes Ruiz" },
                    { "57d95ae2-f217-4898-a249-381252c37acf", null, "Alba Freddy Toledo" },
                    { "595a1a83-8cd9-4c1a-a307-53379d5ca268", null, "Donald Freddy Toledo" },
                    { "598923a8-b2cc-4217-821f-236a08d7ff1b", null, "Alvaro Nicomedes Uribe" },
                    { "5b5e68fc-fc44-4ff9-86a2-781f87466756", null, "Farid Nicomedes Herrera" },
                    { "5b6ba21d-96aa-424a-908d-91fe10925876", null, "Alvaro Anabel Sarmiento" },
                    { "5c6c3970-0dab-48cf-853e-b13401711499", null, "Nicolás Murty Sarmiento" },
                    { "5ca6caba-d7ec-4d7d-8963-b8428f8108fa", null, "Eusebio Silvana Maduro" },
                    { "5cefa115-92dd-4f2b-90ca-8f34552a986c", null, "Eusebio Diomedes Uribe" },
                    { "5dad474d-68d9-4566-9d97-fe29c3077249", null, "Nicolás Rick Herrera" },
                    { "5db2ff39-05bf-4756-bcfd-0eb89b5acb35", null, "Donald Teodoro Ruiz" },
                    { "5dce03c1-4e2b-4eee-9c7e-79f1e82be0f8", null, "Alvaro Freddy Maduro" },
                    { "5fe78fc5-ffa5-47e4-8b79-8953277b09c2", null, "Donald Nicomedes Trump" },
                    { "60ebe1f2-b26e-40d0-9229-bb25bb97b671", null, "Alvaro Rick Ruiz" },
                    { "62245218-09c1-49a8-85a7-de613802f480", null, "Nicolás Rick Sarmiento" },
                    { "6296a66d-e59c-4586-a60c-4912d1b3f5e2", null, "Eusebio Silvana Uribe" },
                    { "63cdddf6-ad16-4e67-ada0-c11426364374", null, "Donald Nicomedes Sarmiento" },
                    { "646525c5-52bd-4f3a-a9ac-7e02c76c1f55", null, "Alba Nicomedes Ruiz" },
                    { "64687011-7b55-4d19-9e51-d849eaf73570", null, "Eusebio Nicomedes Maduro" },
                    { "663c599e-39c6-45cd-ae88-731d1a76c0bc", null, "Felipa Rick Maduro" },
                    { "66405b1c-dc24-41e2-b99a-e2bd6bc26658", null, "Felipa Rick Uribe" },
                    { "67695f05-e52a-439d-905d-1b4fdfe33992", null, "Alba Anabel Uribe" },
                    { "680c1457-8441-47c2-9258-11497b24dd85", null, "Farid Silvana Toledo" },
                    { "68be3d2c-27a1-4451-9b02-7d73de7816a0", null, "Felipa Rick Sarmiento" },
                    { "6c4726f6-169a-4d83-8e4c-23eacdd6d4a7", null, "Eusebio Freddy Uribe" },
                    { "6c7e78d3-e115-45e2-88c6-b2f783fba345", null, "Felipa Murty Maduro" },
                    { "6cba2d44-603e-4079-a4dc-b30886bf4c3d", null, "Alba Murty Toledo" },
                    { "6cc9f120-aa14-48f6-8e88-037e550b4134", null, "Felipa Anabel Maduro" },
                    { "6ce7178d-008f-42e0-8bc9-bd6b1bfcb89b", null, "Donald Silvana Ruiz" },
                    { "6e609456-fb90-4744-b94f-d185563e8952", null, "Farid Diomedes Toledo" },
                    { "6f5a4f57-d71d-4601-8041-90e3fa52cbb9", null, "Alvaro Anabel Herrera" },
                    { "6f88c7be-18d9-481d-8fdf-572df92a1590", null, "Farid Murty Herrera" },
                    { "6fbaaa46-c900-4b39-bca0-963f4afc40c9", null, "Donald Teodoro Sarmiento" },
                    { "70133933-a2ce-49d2-95fb-51d74e61bac8", null, "Alvaro Silvana Maduro" },
                    { "7106d563-7985-4b7e-af53-8c66acc1ca6c", null, "Farid Silvana Maduro" },
                    { "725a000b-e61f-4da6-a02d-9684583d62c5", null, "Nicolás Freddy Herrera" }
                });

            migrationBuilder.InsertData(
                table: "Alumnos",
                columns: new[] { "Id", "CursoId", "Nombre" },
                values: new object[,]
                {
                    { "73bf7c01-7ce9-4ff1-91fa-67583f6b69d1", null, "Eusebio Anabel Maduro" },
                    { "7492ed32-9200-406e-8613-db760035184c", null, "Alvaro Silvana Ruiz" },
                    { "75230298-ef12-4ada-acce-f324b7ec854a", null, "Alvaro Silvana Uribe" },
                    { "754d04c8-8c2d-4acf-9691-bbddd72cb798", null, "Alba Freddy Herrera" },
                    { "7599b8c7-6690-4d84-ab26-2bfc91285222", null, "Farid Murty Maduro" },
                    { "75b02434-91cf-4469-a854-051af069ba05", null, "Eusebio Anabel Herrera" },
                    { "75eb4766-9686-499e-83e4-9e5eee14798b", null, "Donald Nicomedes Maduro" },
                    { "7690573f-4862-4b8d-8dba-cac3b0de25d9", null, "Nicolás Murty Herrera" },
                    { "76ae5cb0-db7a-4f23-b068-566aaedd901b", null, "Nicolás Silvana Herrera" },
                    { "7731bdcf-d38a-4f32-8821-50400da9c9b3", null, "Eusebio Freddy Ruiz" },
                    { "775bfb5c-aed6-4b21-b2d3-33d90cfb0d6b", null, "Nicolás Rick Trump" },
                    { "77d81858-311c-427e-908e-5f7675a5b4f0", null, "Farid Silvana Uribe" },
                    { "7894391a-c53b-47b4-a0c7-3bbaa799698d", null, "Farid Anabel Maduro" },
                    { "79b9fdc2-3c00-4239-b5ef-3ac2faba7320", null, "Alvaro Murty Uribe" },
                    { "7a417934-e153-4484-9b88-b1c82c1ddef3", null, "Alba Rick Uribe" },
                    { "7b4ad122-2bef-4acb-871a-c05d55c4011a", null, "Alba Rick Sarmiento" },
                    { "7ba1e244-4200-42d7-80f9-3a1cb3922e3c", null, "Felipa Silvana Ruiz" },
                    { "7c1d1dec-fa20-44d1-96ee-26354aaa809a", null, "Alba Nicomedes Trump" },
                    { "7d31ccf2-4cec-43cf-b3fc-acf18e8ee130", null, "Felipa Silvana Toledo" },
                    { "7f089fa1-4b82-4180-87ad-004ecd7ce4ae", null, "Felipa Teodoro Uribe" },
                    { "7f48a024-b1a7-4b83-914c-e9ce1da3e73c", null, "Donald Rick Trump" },
                    { "7f5a5fc1-fb55-40f7-beb9-1700e5a96402", null, "Farid Anabel Herrera" },
                    { "8034698b-2727-4cc0-bca7-c2dba1639f9b", null, "Alba Rick Toledo" },
                    { "8097f598-adca-4490-99f7-a1aa0fd51c74", null, "Alba Teodoro Toledo" },
                    { "80f6c806-683e-4c72-9ef7-1fc80e74b4c1", null, "Felipa Nicomedes Sarmiento" },
                    { "81d34ad3-5297-416c-990a-f3f4d273cb36", null, "Donald Nicomedes Uribe" },
                    { "82a0cb12-758f-46f4-a9ec-24c6c4718409", null, "Alvaro Teodoro Herrera" },
                    { "82bf0c61-d80b-45b3-8850-0ef0b4b7ec54", null, "Farid Teodoro Trump" },
                    { "82fc3bf5-0b12-4004-9302-06670f252b39", null, "Farid Murty Trump" },
                    { "8355dacb-13d8-4c90-bb19-27035d349ff3", null, "Donald Freddy Herrera" },
                    { "8399b454-b96b-49aa-925f-85ae42d585fe", null, "Alvaro Anabel Toledo" },
                    { "842aee08-1f7c-4f5e-80aa-1624e221c253", null, "Nicolás Teodoro Maduro" },
                    { "84b52957-2dff-42c7-aac0-1e668b1acc6a", null, "Alba Diomedes Herrera" },
                    { "85b05270-98f3-4a4c-8799-551872265b1b", null, "Nicolás Rick Uribe" },
                    { "860fa685-b063-4a9b-b758-f65079b0791e", null, "Eusebio Freddy Sarmiento" },
                    { "86741553-182b-4a85-ba23-5298a435e5b1", null, "Alba Murty Ruiz" },
                    { "86d539ad-b705-4ce9-92de-ac79814c1ad9", null, "Farid Nicomedes Ruiz" },
                    { "87121b66-cabe-4948-8306-a41076457601", null, "Alba Diomedes Ruiz" },
                    { "87d127a7-fe99-40c4-93d6-2fed36b2beb2", null, "Eusebio Diomedes Maduro" },
                    { "889a7824-0b50-403e-a260-c6a52e47b1ea", null, "Eusebio Nicomedes Sarmiento" },
                    { "893a9640-4d7e-4ec0-99e7-7243c35b2273", null, "Farid Rick Sarmiento" },
                    { "8aadd99f-448e-4339-877a-e390323e09da", null, "Felipa Anabel Uribe" }
                });

            migrationBuilder.InsertData(
                table: "Alumnos",
                columns: new[] { "Id", "CursoId", "Nombre" },
                values: new object[,]
                {
                    { "8e7484d4-ee36-4c16-9697-af15540b3503", null, "Felipa Nicomedes Herrera" },
                    { "8ecabbb9-2a4c-4128-babd-313a4cd617a4", null, "Farid Nicomedes Uribe" },
                    { "90bfa0e7-8679-4de3-8ab6-83ce4dc87a49", null, "Felipa Freddy Toledo" },
                    { "9118adca-92a5-4eb6-a81a-8ba56e2940fc", null, "Alvaro Rick Maduro" },
                    { "9124eebe-d55a-47ed-be96-59676973824b", null, "Felipa Murty Herrera" },
                    { "91dc84de-b1ca-4e31-b284-50f53a8a0b1f", null, "Eusebio Diomedes Sarmiento" },
                    { "93c71fde-13f2-4033-8aa8-f5fa1d9fb2d2", null, "Eusebio Murty Maduro" },
                    { "94d80205-21c9-4eb2-abb4-e8c0133612ce", null, "Farid Nicomedes Toledo" },
                    { "95252e32-53a3-4c7a-b987-cdea1e451a40", null, "Felipa Freddy Trump" },
                    { "9545c6da-6dd0-4797-b0ea-fa9b76fa695b", null, "Donald Diomedes Trump" },
                    { "9574e5cf-bb10-465d-ace2-335d9ab9f6e9", null, "Eusebio Murty Trump" },
                    { "9624264e-e0ae-47e9-9036-92d5eba01675", null, "Felipa Anabel Sarmiento" },
                    { "962b4724-1ade-44d0-a5dd-a96e29e05c8e", null, "Farid Rick Toledo" },
                    { "9796ee3b-61b9-4f38-a766-0f3194cc703a", null, "Nicolás Murty Trump" },
                    { "97a48f54-1239-4ffb-a770-b8c6d6b97628", null, "Alvaro Diomedes Maduro" },
                    { "97ef9e84-0902-40aa-a9a2-d31a7d46aaaf", null, "Alba Murty Sarmiento" },
                    { "98475954-0d58-4a31-b003-13a77fe1eb6a", null, "Eusebio Freddy Toledo" },
                    { "996ffbc7-4690-4c44-8d59-d538bc5b2271", null, "Nicolás Rick Ruiz" },
                    { "9bb32ca0-1af8-4ffd-aa50-3a5c319cfd16", null, "Farid Anabel Trump" },
                    { "9cb039e7-0050-4604-bb45-2388532c0900", null, "Eusebio Freddy Maduro" },
                    { "9d4bb5c8-7908-4de4-86ed-61f3ad47246a", null, "Eusebio Diomedes Trump" },
                    { "9ebb8c65-c9b3-4c31-a877-421f5f33a352", null, "Alvaro Freddy Trump" },
                    { "9f1cdd81-ddbe-488e-b78d-4646094e3ce4", null, "Eusebio Anabel Ruiz" },
                    { "a1361fd8-7081-4cc0-8315-d25c999dd0a8", null, "Felipa Diomedes Herrera" },
                    { "a1ab8b25-ae30-49ba-8096-0eb70b37465a", null, "Alvaro Nicomedes Maduro" },
                    { "a1b67bdb-ca74-453e-831d-71fc6e2a2849", null, "Eusebio Anabel Uribe" },
                    { "a38a5909-f2a5-4237-bdd3-fffea02dde54", null, "Eusebio Murty Toledo" },
                    { "a3c4e1fa-a376-4447-aa1c-3e5b8359de19", null, "Eusebio Rick Maduro" },
                    { "a42711a6-34cc-4bc9-9d25-bcab09ada5c7", null, "Alvaro Murty Trump" },
                    { "a45712eb-7227-4515-b8e6-2232ae83acec", null, "Alba Diomedes Trump" },
                    { "a4c49c20-c16b-4bfa-bb0f-e94a5fa66797", null, "Alba Anabel Herrera" },
                    { "a4c7973e-7757-4ad4-bc5a-d87843f8cc30", null, "Donald Silvana Uribe" },
                    { "a5d9e3a4-fe12-416d-a165-ae851e383847", null, "Felipa Freddy Uribe" },
                    { "a61b1b65-a6de-4b1d-aba7-4cc0fa06bc68", null, "Eusebio Rick Ruiz" },
                    { "a76bb12a-1094-4a4e-ba18-950e6af6024a", null, "Nicolás Diomedes Maduro" },
                    { "a7802bd3-67f4-49ab-a07f-a26cd14a61f3", null, "Farid Freddy Toledo" },
                    { "a7c65fa2-8b45-47d1-906d-17b4c0862ba5", null, "Alba Anabel Maduro" },
                    { "a90ff2ac-2df4-4a65-bb9a-caa368e4b0e0", null, "Alba Teodoro Maduro" },
                    { "aadbbc32-c2c6-4a2c-a482-d98d165fe3da", null, "Alvaro Freddy Ruiz" },
                    { "ab32b580-8a73-4413-9039-6fab92e40b68", null, "Alvaro Rick Toledo" },
                    { "ab3acc0a-e9d3-4026-aca1-96264bc00734", null, "Farid Diomedes Sarmiento" },
                    { "ab8036b2-5d59-419c-a8a5-4391552fb0c8", null, "Alba Freddy Sarmiento" }
                });

            migrationBuilder.InsertData(
                table: "Alumnos",
                columns: new[] { "Id", "CursoId", "Nombre" },
                values: new object[,]
                {
                    { "ab9263f9-e2b6-4b3d-a3f7-86a889552ab7", null, "Donald Anabel Maduro" },
                    { "ad00a381-42cc-465b-b980-266acb163006", null, "Nicolás Freddy Toledo" },
                    { "ad1095ca-6624-4633-9856-96548889f5a5", null, "Alvaro Freddy Uribe" },
                    { "ad62e643-8667-41ae-b734-585f7a276c84", null, "Nicolás Diomedes Ruiz" },
                    { "ad9ae39a-cef5-40ae-9707-aa65cb5459e6", null, "Farid Anabel Ruiz" },
                    { "adc7074f-8d0c-4d89-85b9-df63fec65602", null, "Farid Rick Ruiz" },
                    { "ae2f7904-0784-49a8-b159-9759a94f7b49", null, "Felipa Anabel Ruiz" },
                    { "af020aca-820a-4c88-9df4-a7137767cba8", null, "Eusebio Rick Uribe" },
                    { "af047686-5a03-4182-a3df-60059768767a", null, "Farid Freddy Ruiz" },
                    { "af44f4dc-f307-4813-8428-3b50d776e4f9", null, "Nicolás Anabel Sarmiento" },
                    { "af49784b-c8f2-483e-8edb-9ca140fbd84c", null, "Alba Rick Ruiz" },
                    { "af846b63-c510-4a2d-b2a3-655aa4b80ced", null, "Donald Silvana Toledo" },
                    { "affa09ae-b4bf-4df3-8e2d-e6bd2bd490d3", null, "Farid Nicomedes Trump" },
                    { "b059315e-d783-439b-9ac8-f2431ffda81f", null, "Donald Teodoro Maduro" },
                    { "b09b0f07-fbe1-4247-9aad-0c9e49d00111", null, "Alvaro Murty Maduro" },
                    { "b12d459a-bcd6-498e-b803-adcb8e660cc0", null, "Felipa Rick Toledo" },
                    { "b15d6d63-6dc6-4a36-b094-066b5212be04", null, "Alvaro Silvana Trump" },
                    { "b1b8dbfc-96bd-4152-b5be-0288558f69a3", null, "Alvaro Silvana Toledo" },
                    { "b28f3473-96b6-4714-a025-889ec835ec69", null, "Donald Rick Maduro" },
                    { "b4228f7e-124c-4ddd-a4f3-f913df8d953c", null, "Nicolás Anabel Trump" },
                    { "b427783a-e3dd-4281-921d-5ccb06664221", null, "Alba Freddy Uribe" },
                    { "b4bb08f2-6d30-4be4-94ea-12231a05772b", null, "Alba Nicomedes Sarmiento" },
                    { "b52fd014-52f6-495f-9a8e-e50d9f774e07", null, "Donald Murty Sarmiento" },
                    { "b676d2fd-58ff-48b3-a455-03143372ee82", null, "Felipa Rick Ruiz" },
                    { "b71b4822-6bae-4c9b-8a30-301b8a7e8c33", null, "Farid Freddy Uribe" },
                    { "b793a212-908d-48ee-8b99-09446389c9c3", null, "Nicolás Murty Maduro" },
                    { "b824dcc2-faf2-4a69-91c8-bb51ddb2e61b", null, "Eusebio Silvana Toledo" },
                    { "b88e6913-8120-4acc-9c41-b6817eadeddc", null, "Nicolás Murty Ruiz" },
                    { "b88f277f-44b5-421e-b900-69f4fb1c4dee", null, "Nicolás Teodoro Trump" },
                    { "b9495118-7207-4c36-965d-87dc24a31db8", null, "Felipa Silvana Herrera" },
                    { "b953be0b-42df-4589-8dc1-9b40e62994b6", null, "Farid Silvana Ruiz" },
                    { "b9740710-fb69-4a16-a0d4-4c2c1d180b41", null, "Felipa Silvana Trump" },
                    { "ba449936-3a4f-4fb7-bd86-78fecf1900c9", null, "Farid Freddy Herrera" },
                    { "ba9a1b7b-12e6-432f-bb1b-eb31f03063b4", null, "Alba Silvana Uribe" },
                    { "bb41ce40-e50a-4e3b-8727-9654811948cd", null, "Alba Silvana Trump" },
                    { "bb7ef69d-fd3f-4dbd-8149-7a9178d02570", null, "Eusebio Teodoro Sarmiento" },
                    { "bd531922-2088-4454-9571-6f89e7e5241a", null, "Alba Anabel Ruiz" },
                    { "be376953-45b0-4940-88c2-09af593213d2", null, "Donald Rick Uribe" },
                    { "bebe85e9-8f57-4feb-a3ce-b4ab7db0e2a3", null, "Eusebio Nicomedes Herrera" },
                    { "bf0cf5a4-155e-48db-a2e2-4a8570b59591", null, "Farid Anabel Sarmiento" },
                    { "bfcff143-ab31-446c-8bea-2c8ffe74e7af", null, "Alvaro Teodoro Sarmiento" },
                    { "c0824d9b-40de-4351-97b1-5db70701d5be", null, "Alba Silvana Ruiz" }
                });

            migrationBuilder.InsertData(
                table: "Alumnos",
                columns: new[] { "Id", "CursoId", "Nombre" },
                values: new object[,]
                {
                    { "c132a0fd-93da-4b63-83b2-3647bd254bdc", null, "Farid Murty Toledo" },
                    { "c16546fc-16f5-4e05-a07e-a7eff39e4c93", null, "Donald Murty Ruiz" },
                    { "c21e21c1-df32-4127-81df-5be7c38b240f", null, "Eusebio Murty Ruiz" },
                    { "c3d1d81f-d83c-49a5-a8a4-3d90587a4475", null, "Eusebio Teodoro Herrera" },
                    { "c46ea3dd-4439-43dd-8da0-d12f9985ab8c", null, "Donald Freddy Ruiz" },
                    { "c4705681-4c72-4e72-a7e6-926e6d7fd66b", null, "Nicolás Nicomedes Toledo" },
                    { "c5e22943-fbaf-4273-a833-4e2a61f09170", null, "Eusebio Silvana Ruiz" },
                    { "c669540c-d9d6-45b2-82f4-3f1869f2de16", null, "Nicolás Teodoro Uribe" },
                    { "c92a3696-f07b-4f8d-8c5b-b26369446438", null, "Farid Nicomedes Sarmiento" },
                    { "c9bbcd91-18a3-47a4-82db-75dc6a25f2ea", null, "Farid Teodoro Toledo" },
                    { "ca0e1a9a-15c4-420a-91ce-26ae95b9b10c", null, "Donald Rick Toledo" },
                    { "ca5041a5-a628-4170-bcaf-708170a0ac49", null, "Nicolás Nicomedes Trump" },
                    { "ca59997a-c2a3-46fa-9c67-4bfe14b1743b", null, "Nicolás Diomedes Uribe" },
                    { "ca832bda-5431-4e96-8f7d-a81730b1f400", null, "Alvaro Nicomedes Toledo" },
                    { "cbbb6fe7-56b4-44ce-8904-391fd9fd96f2", null, "Eusebio Nicomedes Toledo" },
                    { "cc334bdf-f7ab-4f96-81e0-413b72628380", null, "Alba Teodoro Uribe" },
                    { "cc742e65-0a50-439a-956e-e5087e5c89af", null, "Farid Rick Herrera" },
                    { "cd0bc705-795c-4ef6-8eb0-0f97d6187856", null, "Alvaro Rick Trump" },
                    { "cd74367d-b3f8-479e-9797-3aafbe941f11", null, "Nicolás Anabel Uribe" },
                    { "ce073533-7df3-4a0f-b634-0fed3a949b96", null, "Nicolás Diomedes Trump" },
                    { "ce125c6f-1f38-4108-a2f7-9e0a966d84ac", null, "Farid Murty Uribe" },
                    { "cf1db6dd-9483-4112-b3c4-f4bd0e41b69c", null, "Alvaro Rick Sarmiento" },
                    { "cf748aeb-ec28-44e2-a398-7c26445b2152", null, "Alba Murty Herrera" },
                    { "cf754f42-0186-4295-912d-0a6133c2c03b", null, "Felipa Diomedes Toledo" },
                    { "d10624ca-7c93-4bc6-bcc8-a65e92b9320f", null, "Donald Nicomedes Toledo" },
                    { "d1c85c04-f53b-41eb-8e39-69f0d1160240", null, "Donald Nicomedes Herrera" },
                    { "d1d71932-c9a6-4c8c-8bb1-20fc3b95b2bc", null, "Farid Silvana Trump" },
                    { "d2f544a3-150b-410b-9231-a628ba02619b", null, "Felipa Murty Toledo" },
                    { "d42f9d52-7d44-4b59-9ccb-116345d7e484", null, "Farid Teodoro Herrera" },
                    { "d432f1d5-9616-4573-8970-db06fe0d80c9", null, "Donald Diomedes Sarmiento" },
                    { "d484615b-9afe-434a-989f-a68a5b0300ae", null, "Alba Silvana Herrera" },
                    { "d4dc5a3a-8804-490c-b730-5d307a488945", null, "Alba Teodoro Sarmiento" },
                    { "d4e07b67-9f0d-4f0c-96f6-c4e78490f5d7", null, "Eusebio Teodoro Maduro" },
                    { "d5066362-5ac4-4410-8b6b-1e6a70b0c177", null, "Eusebio Diomedes Toledo" },
                    { "d57c8601-10d0-4bb5-b16f-bdf1a1e99a17", null, "Farid Teodoro Sarmiento" },
                    { "d6057d13-4ec2-4ac3-89a1-5ce81bdbae86", null, "Farid Rick Trump" },
                    { "d66210c4-c1c8-46a9-9cc7-65cbb4d1670f", null, "Alvaro Anabel Uribe" },
                    { "d6646b32-66b2-443e-a412-18b03b6f46eb", null, "Nicolás Silvana Maduro" },
                    { "d6be2729-5858-4041-bc3b-9dca7598f59d", null, "Donald Anabel Ruiz" },
                    { "d6e14f0c-271e-4c50-a3d7-962cbf0ea563", null, "Alba Freddy Trump" },
                    { "d7747d20-383a-413e-ae36-6d59e096c656", null, "Alvaro Diomedes Uribe" },
                    { "d87cb34c-e79c-4ee2-8968-476e43233232", null, "Donald Diomedes Maduro" }
                });

            migrationBuilder.InsertData(
                table: "Alumnos",
                columns: new[] { "Id", "CursoId", "Nombre" },
                values: new object[,]
                {
                    { "db8395d6-cd0c-4541-be79-e8e3b5de7d6c", null, "Nicolás Freddy Sarmiento" },
                    { "db8f9362-fa79-4e5b-8bd2-ed3c7655a939", null, "Eusebio Silvana Herrera" },
                    { "ddb93273-d3a3-4cae-9799-13532856de61", null, "Eusebio Teodoro Ruiz" },
                    { "dde526c9-827f-4955-b8ff-11b7427225fa", null, "Farid Freddy Maduro" },
                    { "de487450-36cb-473b-93db-0382ed766aae", null, "Felipa Teodoro Trump" },
                    { "de966a1d-d9d4-4221-84d3-06423cf406e5", null, "Nicolás Nicomedes Maduro" },
                    { "dec689b5-a45c-4f14-b6f7-96ae8864e57d", null, "Felipa Freddy Sarmiento" },
                    { "ded34c90-ee08-42b3-b4ca-7793d82daff9", null, "Farid Diomedes Ruiz" },
                    { "dedac880-8ec9-4031-94a1-d2331957e37b", null, "Donald Teodoro Trump" },
                    { "dfa1e096-8d3c-4915-acba-7740c5541138", null, "Alba Anabel Sarmiento" },
                    { "dfcab541-8a2b-43b9-9f93-da5646dd963d", null, "Alba Nicomedes Maduro" },
                    { "dff6b4c6-4681-4bc3-9ba3-d551201de614", null, "Farid Diomedes Maduro" },
                    { "e000cdf5-11bd-461e-af3c-8e3081c51ca9", null, "Felipa Teodoro Maduro" },
                    { "e00b75b9-b79a-4aa4-a5f4-5ac684ac3fa9", null, "Felipa Murty Sarmiento" },
                    { "e05e9e89-4b7f-497b-bed6-cdc01e18391b", null, "Alba Anabel Toledo" },
                    { "e0e9771f-1e90-4929-b529-7f88865b4c0c", null, "Eusebio Murty Uribe" },
                    { "e16e6be1-dacd-43e5-9d0c-45171241cbfe", null, "Felipa Freddy Herrera" },
                    { "e1fd7d77-daac-4077-8989-9c2bdfbe8eca", null, "Alvaro Teodoro Trump" },
                    { "e26fdab4-6d11-4e7e-a469-1ae29fc519cd", null, "Alba Silvana Maduro" },
                    { "e3f86d92-91d0-4cfd-ace9-9212c987de88", null, "Felipa Anabel Toledo" },
                    { "e4a45bcb-7c7d-4100-81a9-3a066776a0aa", null, "Farid Nicomedes Maduro" },
                    { "e62bb57f-b5cd-479f-908f-8f03cfb3933f", null, "Alvaro Rick Uribe" },
                    { "e6d8030d-b489-4a6f-b61c-34cee6e275f3", null, "Nicolás Teodoro Sarmiento" },
                    { "e7188f1a-a5c5-4e8e-980b-9b2ecfcec909", null, "Felipa Murty Ruiz" },
                    { "e8205257-dbde-419d-86f8-64aff92be974", null, "Donald Diomedes Toledo" },
                    { "e8b9a4da-619f-47b3-9187-9f7ae1b23ce2", null, "Nicolás Rick Toledo" },
                    { "ea8e7391-e22e-4bf5-bf73-6ed4932a619d", null, "Felipa Diomedes Ruiz" },
                    { "ecb33570-43f9-42a2-becc-f6c149277b01", null, "Donald Teodoro Herrera" },
                    { "ecbdd214-2354-4d11-8617-bd5d51bf240a", null, "Donald Freddy Uribe" },
                    { "ed5cf45a-0ab4-462c-bb3e-4bab3830a604", null, "Donald Anabel Toledo" },
                    { "ee1b450f-6ee0-49fd-8018-fa4cbfda69a1", null, "Nicolás Silvana Uribe" },
                    { "f04573a1-80e2-434d-804a-f47d342a194c", null, "Donald Silvana Trump" },
                    { "f0bcfb1d-3de0-40e1-8861-8ff8507d2e6b", null, "Nicolás Freddy Uribe" },
                    { "f0e31c6d-8bbc-4941-abc6-17652b8b2e82", null, "Eusebio Silvana Sarmiento" },
                    { "f337b81c-cf86-42b3-975b-da4833b3862e", null, "Felipa Diomedes Sarmiento" },
                    { "f38fbfec-1eca-467d-be2f-bbc8ff81b1f2", null, "Alvaro Silvana Sarmiento" },
                    { "f4bfcaf9-923f-4d1e-8e54-6272aecec274", null, "Donald Nicomedes Ruiz" },
                    { "f4e31f13-f7ba-4deb-9b3a-ba71306e42ea", null, "Alba Freddy Maduro" },
                    { "f56e3309-69e9-406d-9a27-e7d4a1cc767c", null, "Nicolás Murty Toledo" },
                    { "f6b2a1a1-e31e-4457-8c47-dba899a2beec", null, "Nicolás Nicomedes Ruiz" },
                    { "f7ce99d0-4d51-4ced-867a-bdeae51ebf47", null, "Donald Diomedes Ruiz" },
                    { "f7e5e5b8-ced9-4979-a88b-7d427a1c4b5c", null, "Eusebio Rick Sarmiento" }
                });

            migrationBuilder.InsertData(
                table: "Alumnos",
                columns: new[] { "Id", "CursoId", "Nombre" },
                values: new object[,]
                {
                    { "f88cf880-736e-4f8e-b398-2f6adf99c1ea", null, "Felipa Teodoro Sarmiento" },
                    { "f8f3945e-3ed6-4369-a5a8-d762cfdb0d10", null, "Nicolás Murty Uribe" },
                    { "f9028f61-1840-4667-9713-9cfd4cd95f48", null, "Alvaro Teodoro Toledo" },
                    { "f96500c7-17ce-43ff-90a8-c4df9b427096", null, "Felipa Nicomedes Uribe" },
                    { "f9a7e0e3-0c1d-4900-a3a0-9848d482c247", null, "Farid Silvana Sarmiento" },
                    { "f9d029d3-ce5c-4780-8072-27a36c493b9d", null, "Alvaro Nicomedes Herrera" },
                    { "fac1a4a3-c68e-4e39-9b6b-d548ac69e3c4", null, "Alba Diomedes Maduro" },
                    { "fb65f188-7419-4d06-bf0b-5646caf48a59", null, "Alba Teodoro Trump" },
                    { "fbad563a-c7e1-4321-9905-616b268223ca", null, "Felipa Nicomedes Maduro" },
                    { "fbd2b6f1-458a-44d7-9535-a929ca728ddb", null, "Eusebio Rick Trump" },
                    { "fc29758c-6c67-4caf-8830-0419d9b2361b", null, "Felipa Anabel Trump" },
                    { "fcf290c8-abeb-442c-9172-23b5204f244b", null, "Felipa Diomedes Trump" },
                    { "fe7dc1b2-af81-4d00-9f94-c8d12e89747f", null, "Alvaro Teodoro Ruiz" },
                    { "ff8612bc-927a-4ae2-a0d4-f4a5464eed76", null, "Felipa Diomedes Uribe" }
                });

            migrationBuilder.InsertData(
                table: "Asignaturas",
                columns: new[] { "Id", "CursoId", "Nombre" },
                values: new object[,]
                {
                    { "0fe2827b-f4a9-4fc2-9d29-3a3904eba56e", null, "Ciencias Naturales" },
                    { "3fcc9a25-2ed0-4be2-9427-799548e6ae3b", null, "Educación Física" },
                    { "49842275-77eb-4cb1-a3e5-a3900c5dc022", null, "Castellano" },
                    { "574a5477-28aa-4699-bb70-7ec5d2a975a1", null, "Matemáticas" },
                    { "6505baaa-fac3-46b0-ae06-f26c346f9e3f", null, "Programacion" }
                });

            migrationBuilder.InsertData(
                table: "Escuelas",
                columns: new[] { "Id", "AñoDeCreación", "Ciudad", "Dirección", "Nombre", "Pais", "TipoEscuela" },
                values: new object[] { "89b7a1ac-5632-4805-8b1f-149d52bd8baf", 2005, " Bogota", " Avda siempre viva", " Platzi School", " Colombia", 1 });

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
