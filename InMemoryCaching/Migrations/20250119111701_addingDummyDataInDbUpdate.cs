using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InMemoryCaching.Migrations
{
    /// <inheritdoc />
    public partial class addingDummyDataInDbUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("013bf318-726a-4083-ad0a-d03c66064cdc"), "Description of Product 63", "Product 63", 75.82m },
                    { new Guid("0169134c-db53-459b-8fb3-814871a2c020"), "Description of Product 748", "Product 748", 22.11m },
                    { new Guid("019dab72-a79a-43bc-ad2c-ff8d1674b6c3"), "Description of Product 703", "Product 703", 51.44m },
                    { new Guid("021857f9-2a4c-4e6c-9f0e-5b22662479e9"), "Description of Product 12", "Product 12", 72.59m },
                    { new Guid("02269167-046a-42fd-9f14-2b0ea770514f"), "Description of Product 424", "Product 424", 90.22m },
                    { new Guid("025306c3-90b6-4f3b-9e4a-ee9c5822c566"), "Description of Product 819", "Product 819", 24.79m },
                    { new Guid("0263d706-1486-4f1e-b56d-fc3dfe1c1d63"), "Description of Product 43", "Product 43", 58.57m },
                    { new Guid("02b087b0-8935-4639-a8b0-b4d37a4f1302"), "Description of Product 136", "Product 136", 47.73m },
                    { new Guid("02f2c4a6-2867-4421-9e3d-3fc8d34ea0ea"), "Description of Product 670", "Product 670", 26.96m },
                    { new Guid("032f1514-6f67-41ab-aacd-a500f3f9cf70"), "Description of Product 56", "Product 56", 72.93m },
                    { new Guid("033be478-fe88-4e6b-87b8-6da9a2b9a687"), "Description of Product 973", "Product 973", 64.73m },
                    { new Guid("03851548-f039-48fa-803e-5124c47899f3"), "Description of Product 880", "Product 880", 91.14m },
                    { new Guid("03ac1f17-fd0a-4ce1-bd8f-24e52df38854"), "Description of Product 513", "Product 513", 15.01m },
                    { new Guid("03ace643-9eb9-46e4-9474-6952e632f0c4"), "Description of Product 355", "Product 355", 29.86m },
                    { new Guid("03e11643-5623-4b33-b4e4-4895d1c6ab8d"), "Description of Product 905", "Product 905", 69.05m },
                    { new Guid("049e5b3b-6641-4fd2-8141-3a34b9e06529"), "Description of Product 297", "Product 297", 88.17m },
                    { new Guid("0504d0c3-cb83-4a29-a881-c9b17e8ab80f"), "Description of Product 950", "Product 950", 15.02m },
                    { new Guid("0568f7a5-0bf4-4ba7-a2e2-b08865c45e43"), "Description of Product 138", "Product 138", 97.58m },
                    { new Guid("056f1be9-5683-4173-bbd2-b6270c47198b"), "Description of Product 750", "Product 750", 79.61m },
                    { new Guid("057a375c-69ea-4006-a3a8-871a1447e565"), "Description of Product 867", "Product 867", 88.10m },
                    { new Guid("059a44aa-9b9e-466e-9a66-627db8634d91"), "Description of Product 335", "Product 335", 79.13m },
                    { new Guid("05e2a57f-1149-42f6-87bc-dd3f080438f6"), "Description of Product 524", "Product 524", 50.50m },
                    { new Guid("060aa81d-4d74-4488-8a44-e68385c623f0"), "Description of Product 840", "Product 840", 48.04m },
                    { new Guid("062a7e33-43ca-48fc-8889-831c351ed3f2"), "Description of Product 321", "Product 321", 2.40m },
                    { new Guid("06516130-ce8b-482e-b6da-ec2e8e15df17"), "Description of Product 32", "Product 32", 54.37m },
                    { new Guid("066626d1-010d-4f2e-98dc-436d6d2b9ba6"), "Description of Product 231", "Product 231", 44.47m },
                    { new Guid("069717ce-06bc-4cae-81e4-2b8c2f24f5cf"), "Description of Product 280", "Product 280", 59.27m },
                    { new Guid("06b81ae6-0957-4b96-aca0-c546d6062261"), "Description of Product 369", "Product 369", 63.00m },
                    { new Guid("06c4e92a-a21c-415d-bcf9-cd0e97765a43"), "Description of Product 481", "Product 481", 75.87m },
                    { new Guid("06e8676a-d84f-454b-90f2-74bc0bb2b736"), "Description of Product 121", "Product 121", 29.30m },
                    { new Guid("0766b09f-d254-4d4c-a5d3-a47aef064ec2"), "Description of Product 951", "Product 951", 81.29m },
                    { new Guid("0770bbe3-25e6-48d9-a182-a49d9ff86ae9"), "Description of Product 785", "Product 785", 47.95m },
                    { new Guid("07bb8783-ef23-41f3-8240-6f910e17f2fc"), "Description of Product 58", "Product 58", 57.45m },
                    { new Guid("07e5455c-2b20-418d-a422-4e003b56b742"), "Description of Product 145", "Product 145", 1.18m },
                    { new Guid("07e7d5f7-c12e-4c96-860d-e1e7c5e3357c"), "Description of Product 289", "Product 289", 16.66m },
                    { new Guid("07ea2db2-e139-48de-b751-ebbfe4e36c4c"), "Description of Product 144", "Product 144", 52.98m },
                    { new Guid("081ae2a1-942d-4cff-955a-f378c51cf0ef"), "Description of Product 746", "Product 746", 86.19m },
                    { new Guid("082cc873-4b2b-4c0d-a6b1-2f7986596db9"), "Description of Product 338", "Product 338", 23.58m },
                    { new Guid("08e3c904-d105-427f-8e01-e98efdccdfbf"), "Description of Product 947", "Product 947", 6.24m },
                    { new Guid("09240244-8929-4308-8f6b-909b4a8fdc0b"), "Description of Product 483", "Product 483", 85.02m },
                    { new Guid("097de688-f1b3-435a-8671-80e8c2af1073"), "Description of Product 735", "Product 735", 51.74m },
                    { new Guid("09b236b2-1a3a-4c88-819a-649e55cc1603"), "Description of Product 886", "Product 886", 30.47m },
                    { new Guid("09db1394-9604-4b8e-b2ce-9fc5633ad576"), "Description of Product 698", "Product 698", 34.00m },
                    { new Guid("09ed2e39-e4da-4f8c-8988-e09fbc56503d"), "Description of Product 326", "Product 326", 87.65m },
                    { new Guid("0a454e65-352d-465c-8d9e-bf6aea4eba95"), "Description of Product 516", "Product 516", 38.31m },
                    { new Guid("0a6e6c33-77b2-452b-b485-5d2800793821"), "Description of Product 11", "Product 11", 6.59m },
                    { new Guid("0aec3203-0e3c-4510-9f50-192be453a2df"), "Description of Product 647", "Product 647", 66.66m },
                    { new Guid("0b451860-3037-4450-98f7-53e4e2f4624f"), "Description of Product 65", "Product 65", 97.09m },
                    { new Guid("0b57741b-765f-4716-b1b3-4944f45ad20a"), "Description of Product 265", "Product 265", 5.98m },
                    { new Guid("0b5e947c-5920-43ea-a269-a773b37fdc77"), "Description of Product 193", "Product 193", 58.05m },
                    { new Guid("0bb454fd-f76a-4a80-bd9d-1b3a0f654755"), "Description of Product 407", "Product 407", 40.34m },
                    { new Guid("0ca299c1-6b7a-4ecc-9f1a-92a4c4cd7027"), "Description of Product 734", "Product 734", 66.89m },
                    { new Guid("0d2b4ca8-6d6e-4fed-952a-99efef524b2e"), "Description of Product 656", "Product 656", 81.96m },
                    { new Guid("0d368d7d-84e4-4fac-8e81-758d73a95d5e"), "Description of Product 500", "Product 500", 66.85m },
                    { new Guid("0daaaf8a-0921-4dd3-8f72-b8790e13a3db"), "Description of Product 515", "Product 515", 58.34m },
                    { new Guid("0ddfabd5-b134-42af-9442-d0117efd2572"), "Description of Product 569", "Product 569", 61.53m },
                    { new Guid("0dff4dc0-cc41-4b5e-b230-a0d7108fb023"), "Description of Product 154", "Product 154", 64.09m },
                    { new Guid("0e14d865-9397-413b-bacf-3ef7062dff25"), "Description of Product 766", "Product 766", 14.66m },
                    { new Guid("0ef10b6b-ac81-41f2-bc3e-bf8bef0b7625"), "Description of Product 34", "Product 34", 33.71m },
                    { new Guid("0f190f4a-391c-48a5-bea8-c9320429f7a0"), "Description of Product 234", "Product 234", 60.35m },
                    { new Guid("0f3149a5-3f02-4128-a3e1-410d002422b7"), "Description of Product 684", "Product 684", 67.73m },
                    { new Guid("0facddc5-b38e-47ba-b6ac-a9b864a082e1"), "Description of Product 372", "Product 372", 24.95m },
                    { new Guid("0ffdb766-2695-47c4-9602-6fe9d7d1e167"), "Description of Product 429", "Product 429", 31.64m },
                    { new Guid("10275268-0929-4a70-9086-f76734d06016"), "Description of Product 899", "Product 899", 10.69m },
                    { new Guid("10797d9d-0018-49ee-9765-587639355107"), "Description of Product 942", "Product 942", 63.11m },
                    { new Guid("1110e697-fe6e-46dc-84ea-67225f38d628"), "Description of Product 900", "Product 900", 86.96m },
                    { new Guid("11448660-376e-486a-a56f-2a314ba97c8a"), "Description of Product 270", "Product 270", 24.32m },
                    { new Guid("116e6127-3259-4224-8954-ecbc210e2fd7"), "Description of Product 708", "Product 708", 87.33m },
                    { new Guid("118351f6-df58-4cea-9cf1-b799a3a8f495"), "Description of Product 358", "Product 358", 88.10m },
                    { new Guid("1221efe8-2cd6-4c00-adc0-5c8a38404dc2"), "Description of Product 78", "Product 78", 70.30m },
                    { new Guid("1222e752-b2b1-46cf-8801-d301ae0fd993"), "Description of Product 117", "Product 117", 39.10m },
                    { new Guid("124524dd-9a35-489e-affb-8c3dee83453b"), "Description of Product 844", "Product 844", 63.49m },
                    { new Guid("1254d212-f2a8-48c1-bb38-60879a1c7920"), "Description of Product 37", "Product 37", 62.59m },
                    { new Guid("127adc40-0f7f-41dc-bbed-0d57abfc9a61"), "Description of Product 301", "Product 301", 85.97m },
                    { new Guid("12b4b3b8-96da-45f1-9f4a-838ce131835d"), "Description of Product 84", "Product 84", 95.43m },
                    { new Guid("12bab8f9-606a-4c68-b4fe-edd736328b3f"), "Description of Product 370", "Product 370", 8.41m },
                    { new Guid("1317b0a4-dbdd-4458-bc04-9c068f7fdaf7"), "Description of Product 541", "Product 541", 40.28m },
                    { new Guid("134c5b90-a1f1-4654-98c0-17c88c0d4520"), "Description of Product 995", "Product 995", 70.36m },
                    { new Guid("136d4beb-39a0-4649-93d3-05162c214858"), "Description of Product 920", "Product 920", 19.74m },
                    { new Guid("143db399-6e11-4149-ad0b-8af74c9c1858"), "Description of Product 794", "Product 794", 58.04m },
                    { new Guid("145d4444-1f53-4813-95c6-e9fe445fe2c8"), "Description of Product 70", "Product 70", 18.84m },
                    { new Guid("14ead0c3-6f57-4b05-9ed0-74f47e9e564a"), "Description of Product 283", "Product 283", 13.71m },
                    { new Guid("154d54ca-4c86-4307-b81f-72e2f7e0605a"), "Description of Product 544", "Product 544", 10.65m },
                    { new Guid("1564810e-b430-42a9-9471-bdf645b1d988"), "Description of Product 764", "Product 764", 20.79m },
                    { new Guid("15c7cc99-3881-4244-bd98-77a0efb56475"), "Description of Product 60", "Product 60", 56.20m },
                    { new Guid("1666e785-cedf-47d6-bd48-dffda5bf7881"), "Description of Product 456", "Product 456", 19.46m },
                    { new Guid("166b4785-77a8-4fd9-9395-aaac47afe73e"), "Description of Product 722", "Product 722", 33.85m },
                    { new Guid("16dbe01b-f161-4fe0-bc18-8ae20696be03"), "Description of Product 781", "Product 781", 86.76m },
                    { new Guid("17249174-234b-49d6-a125-795323ab0049"), "Description of Product 793", "Product 793", 50.33m },
                    { new Guid("1755de61-0cf1-48a5-8cb8-2b8bac70f774"), "Description of Product 537", "Product 537", 25.97m },
                    { new Guid("1788f9e0-7521-4ce4-81f7-4e6943b5f5ae"), "Description of Product 938", "Product 938", 63.76m },
                    { new Guid("179dce33-dae3-42da-b196-8af4b7c946f5"), "Description of Product 422", "Product 422", 64.31m },
                    { new Guid("17eb68a8-3c13-47fb-94b2-d156c10c4368"), "Description of Product 566", "Product 566", 13.98m },
                    { new Guid("1810fd80-1a68-4fb1-8cdf-08bb4f13f514"), "Description of Product 643", "Product 643", 65.52m },
                    { new Guid("182482d5-0131-43fa-bc24-7783e3ea62c3"), "Description of Product 584", "Product 584", 85.06m },
                    { new Guid("1831f67d-e70a-41a2-a7ea-432bc28c35e0"), "Description of Product 288", "Product 288", 8.87m },
                    { new Guid("1877a0c6-1711-40c6-becb-8d8c60ec777d"), "Description of Product 214", "Product 214", 83.41m },
                    { new Guid("18843646-b502-4193-ab6e-15f06c4b9b8f"), "Description of Product 479", "Product 479", 55.84m },
                    { new Guid("18b313f6-5b9f-4fc0-b249-1b5db2a1bae3"), "Description of Product 543", "Product 543", 42.75m },
                    { new Guid("192223fb-5781-4729-a539-500f67634636"), "Description of Product 921", "Product 921", 92.03m },
                    { new Guid("1935a4ef-aae3-498b-9a43-1e0225bd837a"), "Description of Product 3", "Product 3", 39.62m },
                    { new Guid("194a91bd-3c6d-49fa-9477-27b18dd00782"), "Description of Product 79", "Product 79", 93.11m },
                    { new Guid("199d5182-e4e9-402a-b49f-d916882779f7"), "Description of Product 755", "Product 755", 31.12m },
                    { new Guid("19aa7ea8-0777-4fb8-927f-75cb6d7bdbed"), "Description of Product 612", "Product 612", 71.63m },
                    { new Guid("19d14828-e2d8-4959-9ad6-6bee4035deb2"), "Description of Product 243", "Product 243", 87.03m },
                    { new Guid("19e31d37-bf2f-4574-87a4-a159e8ebf9e5"), "Description of Product 617", "Product 617", 91.54m },
                    { new Guid("19ff24a6-22b2-4c9c-b7cc-4de79d51baa4"), "Description of Product 936", "Product 936", 9.42m },
                    { new Guid("1a1d7b82-ecc3-474a-be43-56e0bdcc5d54"), "Description of Product 309", "Product 309", 49.84m },
                    { new Guid("1a3e2efb-33eb-4718-a6ea-4e60bbda32c1"), "Description of Product 49", "Product 49", 7.81m },
                    { new Guid("1a685c6c-920b-4abf-abe3-e1a98febb62d"), "Description of Product 945", "Product 945", 69.11m },
                    { new Guid("1a7289c8-2eb4-4958-9d7f-6f17c8725893"), "Description of Product 548", "Product 548", 64.41m },
                    { new Guid("1a9051a6-3751-4088-9fbc-943f00ab2eb1"), "Description of Product 623", "Product 623", 4.97m },
                    { new Guid("1b336fa4-2cb5-4c4c-8c5a-96f6a2787629"), "Description of Product 702", "Product 702", 46.89m },
                    { new Guid("1b3e13a0-fc9d-4840-bf99-9fcb4cd29ad3"), "Description of Product 402", "Product 402", 74.97m },
                    { new Guid("1b696a28-1eb7-4459-b6b2-0722c8f0049b"), "Description of Product 373", "Product 373", 25.61m },
                    { new Guid("1bc9c586-738c-4d32-8eb1-eac4d3f8eb23"), "Description of Product 227", "Product 227", 10.12m },
                    { new Guid("1be2789a-92d5-411d-acce-41c23d13981e"), "Description of Product 604", "Product 604", 26.60m },
                    { new Guid("1c073f02-1d2d-457e-858a-cfca83932c01"), "Description of Product 172", "Product 172", 58.14m },
                    { new Guid("1c3b6219-8a9e-4660-bfa1-88fae69e3f57"), "Description of Product 5", "Product 5", 61.30m },
                    { new Guid("1cbefad9-5b38-4d77-93e9-cf9ec257941c"), "Description of Product 727", "Product 727", 27.35m },
                    { new Guid("1d43d180-f017-441a-a656-a4d7ea2fa1d2"), "Description of Product 195", "Product 195", 30.05m },
                    { new Guid("1d4661e1-358d-4108-99ec-3b7fa430bfd7"), "Description of Product 175", "Product 175", 63.87m },
                    { new Guid("1d6acfd2-ebaf-463a-b282-04b09e2d1208"), "Description of Product 754", "Product 754", 99.53m },
                    { new Guid("1d8dabf8-b80b-4553-a02e-091d3f146938"), "Description of Product 769", "Product 769", 26.33m },
                    { new Guid("1da41c1c-e48d-4e08-b931-41e5410c04ce"), "Description of Product 534", "Product 534", 46.18m },
                    { new Guid("1def29b2-b221-442d-b3a6-8be62c087e1e"), "Description of Product 420", "Product 420", 4.12m },
                    { new Guid("1f842abc-e232-4d1b-8cfa-3fc339318007"), "Description of Product 997", "Product 997", 36.06m },
                    { new Guid("20044fa9-39ef-4b8c-9973-39d57e0fbc68"), "Description of Product 987", "Product 987", 57.17m },
                    { new Guid("203bb72b-5785-493c-9e5d-ae5075276557"), "Description of Product 560", "Product 560", 33.95m },
                    { new Guid("20498469-fd84-4d85-877d-7ae586240a4a"), "Description of Product 804", "Product 804", 71.13m },
                    { new Guid("207888bf-f626-4a6d-be89-a5d2616d5723"), "Description of Product 540", "Product 540", 66.82m },
                    { new Guid("20ef7b7a-0f70-4dac-a17e-800ab2ce9b29"), "Description of Product 528", "Product 528", 33.46m },
                    { new Guid("2157575a-4d26-412d-8448-f2c471597baf"), "Description of Product 505", "Product 505", 38.79m },
                    { new Guid("21bea758-5fd4-45d3-8326-8944a68533fc"), "Description of Product 151", "Product 151", 17.50m },
                    { new Guid("221a5944-bd09-4f69-9769-26a79ea74dbb"), "Description of Product 811", "Product 811", 27.66m },
                    { new Guid("2231502c-f17c-49ed-a2b0-e14591b48f51"), "Description of Product 33", "Product 33", 20.61m },
                    { new Guid("226b95e5-5065-47dc-b57d-2ea11f9f2a99"), "Description of Product 262", "Product 262", 54.33m },
                    { new Guid("2281c851-f04b-4ca9-bc59-393f0287c45d"), "Description of Product 38", "Product 38", 44.26m },
                    { new Guid("234ec62d-7f7b-4117-b9fe-27a198513ed4"), "Description of Product 542", "Product 542", 38.75m },
                    { new Guid("238682df-ce55-4685-8c12-279c7843b009"), "Description of Product 410", "Product 410", 39.06m },
                    { new Guid("239921fb-0917-44c3-a217-40d34480fa5a"), "Description of Product 705", "Product 705", 25.63m },
                    { new Guid("23b088f6-3c12-4c17-900b-c7bd638d1469"), "Description of Product 506", "Product 506", 30.39m },
                    { new Guid("23c193ba-7ab3-4620-9788-c0e47ce312dd"), "Description of Product 418", "Product 418", 6.02m },
                    { new Guid("23c8d688-5dd6-4347-a0e3-1547c4399296"), "Description of Product 333", "Product 333", 20.20m },
                    { new Guid("23e1c3ff-e99a-4c50-9795-fc0df739ee6b"), "Description of Product 476", "Product 476", 83.24m },
                    { new Guid("23e871af-475b-4d6f-9e15-78afe8b257da"), "Description of Product 795", "Product 795", 99.86m },
                    { new Guid("23ebebcb-b4dd-490c-86f6-553341c5504d"), "Description of Product 74", "Product 74", 96.92m },
                    { new Guid("2409e542-b505-4a70-9ac9-005eff7a7354"), "Description of Product 687", "Product 687", 99.70m },
                    { new Guid("244165a3-a96f-4ae6-a3dc-4f8672a71134"), "Description of Product 523", "Product 523", 55.49m },
                    { new Guid("24dc02a0-deb2-4fe7-b3bb-1e82f8159a63"), "Description of Product 207", "Product 207", 37.32m },
                    { new Guid("24e41536-c4df-480a-93e8-dedbe902b1ec"), "Description of Product 347", "Product 347", 16.31m },
                    { new Guid("25c1615c-7d3c-45ed-8c0d-e1962f6e0e82"), "Description of Product 368", "Product 368", 59.59m },
                    { new Guid("25ffdac0-71a6-4256-b3b2-8565583255ef"), "Description of Product 340", "Product 340", 76.73m },
                    { new Guid("2604c15f-bc78-4225-8bcd-17f2792fb972"), "Description of Product 458", "Product 458", 82.87m },
                    { new Guid("260fec74-5402-423e-b667-ea618abddbb5"), "Description of Product 611", "Product 611", 33.48m },
                    { new Guid("26305ade-62ea-4b6d-a22c-7d7dbf9efd04"), "Description of Product 298", "Product 298", 4.02m },
                    { new Guid("2636cd00-c832-4a4b-850f-dd96ae92c6c8"), "Description of Product 362", "Product 362", 37.07m },
                    { new Guid("267776e0-5428-4048-977a-73c63a42e50a"), "Description of Product 752", "Product 752", 37.74m },
                    { new Guid("26fb0157-484e-4ed3-8fac-9d500e105f49"), "Description of Product 527", "Product 527", 43.25m },
                    { new Guid("270f06ec-88c2-4e27-8051-be0b7749dffb"), "Description of Product 916", "Product 916", 41.17m },
                    { new Guid("27aa603d-2d13-4469-893f-5f27b86e647c"), "Description of Product 143", "Product 143", 3.22m },
                    { new Guid("27e344bc-64be-4dd2-823b-c90be89c3d3e"), "Description of Product 473", "Product 473", 16.22m },
                    { new Guid("27e8088d-4525-40d2-949f-4dd3346668f9"), "Description of Product 59", "Product 59", 19.06m },
                    { new Guid("27f5e16f-6c78-4c08-9828-262585a0bb36"), "Description of Product 302", "Product 302", 31.71m },
                    { new Guid("2842b9fc-c680-4820-8996-60f8d0763eb8"), "Description of Product 889", "Product 889", 41.66m },
                    { new Guid("288db679-39f4-4675-8dfb-ca3aa157c12c"), "Description of Product 775", "Product 775", 82.56m },
                    { new Guid("28a34215-7ad1-490d-b365-0677216998a7"), "Description of Product 498", "Product 498", 4.48m },
                    { new Guid("28cb0062-3e91-45c1-82dd-0b6e354c3b3c"), "Description of Product 797", "Product 797", 11.14m },
                    { new Guid("298e1926-0ddb-454f-8b16-3556f41066c7"), "Description of Product 22", "Product 22", 44.36m },
                    { new Guid("2ae0ea2b-9438-4400-969e-bd2f60cc1216"), "Description of Product 197", "Product 197", 71.92m },
                    { new Guid("2b2ad4e4-f059-426a-8b25-270ee08239b9"), "Description of Product 495", "Product 495", 64.98m },
                    { new Guid("2b442f6c-8609-4e2a-ba93-97d1b2826c4d"), "Description of Product 178", "Product 178", 22.92m },
                    { new Guid("2b5a8a07-c726-41d9-bd28-b75ccc6ea6c1"), "Description of Product 979", "Product 979", 36.30m },
                    { new Guid("2b8fc2df-7272-4b6a-b869-32291e53f09c"), "Description of Product 689", "Product 689", 52.32m },
                    { new Guid("2bf8a009-cfd3-459e-9bdd-37b9053a1428"), "Description of Product 229", "Product 229", 98.66m },
                    { new Guid("2c00eb9f-f67e-425c-8029-d5e03bc06dea"), "Description of Product 405", "Product 405", 73.60m },
                    { new Guid("2c7c3b70-f27b-4a14-8b3d-9a02b4c47425"), "Description of Product 390", "Product 390", 43.45m },
                    { new Guid("2c846d17-d34d-4ad4-9dee-0f525afacea0"), "Description of Product 168", "Product 168", 96.75m },
                    { new Guid("2c8b47d6-5c6c-4c40-ad44-b2d9f467b8b0"), "Description of Product 266", "Product 266", 7.08m },
                    { new Guid("2c96514d-0a29-4f26-bbf9-1a592c6cbea1"), "Description of Product 838", "Product 838", 41.86m },
                    { new Guid("2cce1d78-1566-4d49-9a71-a03651762602"), "Description of Product 682", "Product 682", 82.36m },
                    { new Guid("2d43f8f6-7990-4e1a-b23b-7e58da04cdd1"), "Description of Product 417", "Product 417", 49.44m },
                    { new Guid("2dc44766-4d6c-42b7-a12b-499ea3177d44"), "Description of Product 737", "Product 737", 8.36m },
                    { new Guid("2defc1be-c8c4-498d-baf9-13133b75d635"), "Description of Product 233", "Product 233", 37.78m },
                    { new Guid("2e4f9c40-fb42-410c-b895-1052b6c64abc"), "Description of Product 73", "Product 73", 70.41m },
                    { new Guid("2e8b921f-8938-4b73-b981-03ba70cd1f1d"), "Description of Product 933", "Product 933", 96.47m },
                    { new Guid("2ecd9a85-d125-4e84-bb73-64de41c9d45e"), "Description of Product 153", "Product 153", 4.55m },
                    { new Guid("2f1e1146-31cd-46eb-8e1d-463fc7c15a0b"), "Description of Product 971", "Product 971", 35.67m },
                    { new Guid("2f8723da-88f8-4515-9c5e-ab6e9427a035"), "Description of Product 1000", "Product 1000", 85.70m },
                    { new Guid("2fed1a23-9b95-4acd-8052-fb86f27d16b1"), "Description of Product 782", "Product 782", 76.49m },
                    { new Guid("304b703a-bbaf-49e8-a912-b0c75d38cfc2"), "Description of Product 103", "Product 103", 93.87m },
                    { new Guid("30705c88-b835-4783-9f42-cf71d5ff333b"), "Description of Product 203", "Product 203", 38.37m },
                    { new Guid("30b8a5d3-1609-4f48-89f6-34664c3a7145"), "Description of Product 501", "Product 501", 81.13m },
                    { new Guid("30c9902f-6df3-4f3f-b63d-0c60cd961414"), "Description of Product 277", "Product 277", 39.66m },
                    { new Guid("31364a03-bfd3-4699-8946-13be30537137"), "Description of Product 888", "Product 888", 83.64m },
                    { new Guid("317a0fff-b75c-4174-9e4a-db746dce4baa"), "Description of Product 315", "Product 315", 70.14m },
                    { new Guid("317c5003-08e1-43a5-a859-eea41504e265"), "Description of Product 570", "Product 570", 67.60m },
                    { new Guid("3206fa3a-151d-4a96-801f-4b8c9389252f"), "Description of Product 96", "Product 96", 61.99m },
                    { new Guid("324110bf-d3e6-4c7d-b057-ec11b80fb22a"), "Description of Product 790", "Product 790", 77.04m },
                    { new Guid("3267a89c-b60c-4cbc-92bb-61510229a725"), "Description of Product 353", "Product 353", 59.96m },
                    { new Guid("327f9f44-01f1-456e-8ee4-c3f3ed92e57c"), "Description of Product 608", "Product 608", 41.86m },
                    { new Guid("329f2c15-2210-45bd-98ed-5acb210e5e47"), "Description of Product 872", "Product 872", 81.90m },
                    { new Guid("33056146-4294-42e5-a8cc-eeb64b4a60a8"), "Description of Product 313", "Product 313", 60.96m },
                    { new Guid("33191e68-f805-45f9-9eeb-3e76e48f0dd3"), "Description of Product 406", "Product 406", 78.00m },
                    { new Guid("33192747-fd1b-41a5-9cc1-c2365c59bd25"), "Description of Product 644", "Product 644", 69.24m },
                    { new Guid("3338cc83-3f7a-442d-a30b-b44d5b6bf4a8"), "Description of Product 994", "Product 994", 57.78m },
                    { new Guid("333f94d2-53f7-4abb-8781-f59caad01350"), "Description of Product 51", "Product 51", 13.53m },
                    { new Guid("3340b4cc-1d44-4bc2-8eb7-7f6e3ee6cd43"), "Description of Product 81", "Product 81", 72.76m },
                    { new Guid("33469e8c-fcc5-4926-8d19-4cbedb8fe462"), "Description of Product 284", "Product 284", 51.12m },
                    { new Guid("33cf073a-9b17-489e-a14e-0b3904da19eb"), "Description of Product 416", "Product 416", 45.18m },
                    { new Guid("33f90976-e31b-4a31-901b-5b6d4913b649"), "Description of Product 870", "Product 870", 84.95m },
                    { new Guid("340b939b-8c86-4ed5-a2d5-c5d4a171ee26"), "Description of Product 318", "Product 318", 88.33m },
                    { new Guid("347b2ece-dad3-419c-b436-58f79a641808"), "Description of Product 465", "Product 465", 80.06m },
                    { new Guid("34e5e13e-779d-441b-b8d1-d94b71984c22"), "Description of Product 62", "Product 62", 42.11m },
                    { new Guid("35bcea6c-c918-49a4-a8a5-2ebe5a0a951c"), "Description of Product 182", "Product 182", 13.30m },
                    { new Guid("35c546e6-ce6b-4eaa-b36e-d05a7ad115ec"), "Description of Product 190", "Product 190", 71.13m },
                    { new Guid("35f37120-4763-4de6-b4ae-6ae142798a9f"), "Description of Product 510", "Product 510", 9.63m },
                    { new Guid("3624f564-6221-42dd-8ecd-839eab7432b2"), "Description of Product 592", "Product 592", 64.83m },
                    { new Guid("3643640e-42f2-473f-aafe-ff078e951653"), "Description of Product 447", "Product 447", 93.78m },
                    { new Guid("3682b275-30d8-4457-8e53-49d8b6513bb0"), "Description of Product 158", "Product 158", 5.88m },
                    { new Guid("36e2effd-f3c5-4dea-bb35-ef43109d1b89"), "Description of Product 974", "Product 974", 31.42m },
                    { new Guid("36e537ac-911a-4706-ae78-1b6aacc53b14"), "Description of Product 977", "Product 977", 39.17m },
                    { new Guid("3749f9aa-43ec-49cd-bd70-87fb9dd4c2e0"), "Description of Product 943", "Product 943", 80.29m },
                    { new Guid("37ad4596-f75f-458f-9a26-f589938cec3c"), "Description of Product 730", "Product 730", 39.81m },
                    { new Guid("3814d051-5798-445d-9abb-bcfbc244cc40"), "Description of Product 244", "Product 244", 90.02m },
                    { new Guid("38430046-4f8c-420a-9774-e7e1e8b3df39"), "Description of Product 137", "Product 137", 97.68m },
                    { new Guid("389f7408-0352-4c8c-a71c-dbd5a8979f18"), "Description of Product 446", "Product 446", 48.23m },
                    { new Guid("38d914a6-9ace-46ab-b678-e45475e0fbf6"), "Description of Product 630", "Product 630", 64.80m },
                    { new Guid("39705780-1af2-4ebe-ad63-a5174c1a70f1"), "Description of Product 771", "Product 771", 84.29m },
                    { new Guid("399c3839-90b0-4cfd-b932-cdb0633162f3"), "Description of Product 695", "Product 695", 53.20m },
                    { new Guid("39abd499-cd5d-47ca-a4af-f377fad6c214"), "Description of Product 423", "Product 423", 69.52m },
                    { new Guid("3a08ab64-6d26-4b8d-a5e3-48c534a17a97"), "Description of Product 228", "Product 228", 6.65m },
                    { new Guid("3a114e9e-590a-4df2-b0c6-3781bf59d69b"), "Description of Product 625", "Product 625", 54.11m },
                    { new Guid("3a5a36a6-433b-4177-a1ca-ee8afb93695e"), "Description of Product 427", "Product 427", 36.49m },
                    { new Guid("3a72b945-6bf4-48e6-9668-455cdef507a5"), "Description of Product 7", "Product 7", 35.89m },
                    { new Guid("3a9d5afd-593e-49b3-a631-627d5d1b350e"), "Description of Product 836", "Product 836", 76.29m },
                    { new Guid("3b2324f7-4f89-479c-aef6-946896b2e494"), "Description of Product 863", "Product 863", 1.67m },
                    { new Guid("3b3f340f-040a-4457-b3b7-b5992ec4e6a1"), "Description of Product 909", "Product 909", 39.28m },
                    { new Guid("3ba6c467-ccc6-4fb9-93c2-164db821607e"), "Description of Product 246", "Product 246", 83.53m },
                    { new Guid("3bb115a3-a166-4a52-affe-0a834a98039a"), "Description of Product 35", "Product 35", 89.78m },
                    { new Guid("3bdfb840-f844-49c5-8f44-08345cc57796"), "Description of Product 603", "Product 603", 23.66m },
                    { new Guid("3bfcb70c-5bc5-404e-8d1b-504c934c21c2"), "Description of Product 877", "Product 877", 88.45m },
                    { new Guid("3d240f0e-9e75-46f6-995c-55451935e3fe"), "Description of Product 113", "Product 113", 39.37m },
                    { new Guid("3d979c9b-ec6d-4b94-91a3-5d8791f22bcd"), "Description of Product 832", "Product 832", 59.72m },
                    { new Guid("3dab78da-0d2f-405b-8950-c004bb99ac5e"), "Description of Product 567", "Product 567", 6.71m },
                    { new Guid("3dde9c07-00d5-4dab-a112-c5332d1f5bb0"), "Description of Product 461", "Product 461", 27.66m },
                    { new Guid("3e0b1032-404d-4f4f-9aee-1eff3f792df5"), "Description of Product 397", "Product 397", 60.66m },
                    { new Guid("3e790263-13b2-4785-bef3-f5a5744c776c"), "Description of Product 668", "Product 668", 1.30m },
                    { new Guid("40d66088-731d-4069-9fa4-ccc003fb8232"), "Description of Product 494", "Product 494", 62.33m },
                    { new Guid("40eca944-85eb-4e36-acd3-1b9fc474d206"), "Description of Product 106", "Product 106", 33.11m },
                    { new Guid("41aa2c64-37b7-4970-a493-a6eeaf6a0794"), "Description of Product 667", "Product 667", 93.97m },
                    { new Guid("41f8f433-2eff-4649-bbb9-79c9649f0eca"), "Description of Product 862", "Product 862", 34.48m },
                    { new Guid("420df1b1-1efb-4396-8f68-b1f4f449c960"), "Description of Product 952", "Product 952", 95.45m },
                    { new Guid("42161d5e-8cad-4215-b1de-8ebed66cc4b8"), "Description of Product 448", "Product 448", 29.11m },
                    { new Guid("421d3020-c724-454b-94ea-061919f7d329"), "Description of Product 192", "Product 192", 75.42m },
                    { new Guid("4222bbdf-6c27-45b5-9b20-8aef03801a5e"), "Description of Product 530", "Product 530", 14.96m },
                    { new Guid("422a85bb-1170-40e5-8843-c1ddfb9177cf"), "Description of Product 497", "Product 497", 46.34m },
                    { new Guid("42700385-5153-4745-9c2a-279db7f5ce6d"), "Description of Product 873", "Product 873", 79.14m },
                    { new Guid("428e2c20-80fd-4c59-8937-c1372e60782f"), "Description of Product 384", "Product 384", 9.59m },
                    { new Guid("42f9a73f-d65b-4f45-ba18-ede8382ce3cd"), "Description of Product 970", "Product 970", 88.15m },
                    { new Guid("43499ffd-7a9b-401d-87d9-91db7684f547"), "Description of Product 148", "Product 148", 90.61m },
                    { new Guid("436aed0a-314c-4c8e-a025-56ffd35081eb"), "Description of Product 241", "Product 241", 99.61m },
                    { new Guid("4371ef37-7887-4a6b-923e-04f9ade90cd8"), "Description of Product 129", "Product 129", 48.92m },
                    { new Guid("43e36b7e-eabb-4477-b1bd-9cc88a5b9e95"), "Description of Product 852", "Product 852", 51.44m },
                    { new Guid("441d4005-72fa-472d-9366-66cdb1368e83"), "Description of Product 935", "Product 935", 81.42m },
                    { new Guid("44a4aef3-e622-40ba-9900-8bad5b91e197"), "Description of Product 230", "Product 230", 1.87m },
                    { new Guid("452d03be-5776-4547-9d86-8e58fa767e6d"), "Description of Product 469", "Product 469", 57.77m },
                    { new Guid("453cc63d-0f32-498d-87d3-19fe7e83650a"), "Description of Product 519", "Product 519", 61.06m },
                    { new Guid("45430934-ff92-47d7-b729-312e73ffe14d"), "Description of Product 823", "Product 823", 50.42m },
                    { new Guid("455b7b91-1821-4768-a382-ea53b5e79f7d"), "Description of Product 672", "Product 672", 45.27m },
                    { new Guid("45ec8bbb-c75f-456f-85be-620482caa408"), "Description of Product 351", "Product 351", 74.42m },
                    { new Guid("45fe0cb9-dafc-431a-bafe-f5d03f061b4c"), "Description of Product 421", "Product 421", 47.43m },
                    { new Guid("4605d4c0-adb8-411d-bc1c-fcc9d30cacc2"), "Description of Product 854", "Product 854", 8.44m },
                    { new Guid("462b9576-8ea7-4fa6-b5a4-9eba53d07c62"), "Description of Product 827", "Product 827", 34.45m },
                    { new Guid("46724efc-8219-43fb-b811-eb97d37f830f"), "Description of Product 382", "Product 382", 25.54m },
                    { new Guid("467483db-5186-4af8-aead-a12f2e3aee40"), "Description of Product 41", "Product 41", 77.20m },
                    { new Guid("46d99759-3255-4b09-a116-d6bafda7b9cc"), "Description of Product 478", "Product 478", 3.75m },
                    { new Guid("46f6cb64-eafc-4d5c-950d-b95c545381f1"), "Description of Product 435", "Product 435", 97.94m },
                    { new Guid("475b81b1-5b3c-45b0-8382-7e46c4c7953c"), "Description of Product 330", "Product 330", 59.16m },
                    { new Guid("47627b67-e4a2-4596-97bc-1ae74b3e96e0"), "Description of Product 279", "Product 279", 9.20m },
                    { new Guid("4773554f-ce24-4f64-b08f-1a5475067010"), "Description of Product 784", "Product 784", 22.68m },
                    { new Guid("478141c9-c18b-4b67-b0f0-ae8e8f18a58f"), "Description of Product 924", "Product 924", 52.06m },
                    { new Guid("4792bd85-d949-4a9e-9936-9bc854ef692e"), "Description of Product 98", "Product 98", 92.49m },
                    { new Guid("47bf8ec8-fdf9-4c6e-bf04-306eefcd29b4"), "Description of Product 357", "Product 357", 61.58m },
                    { new Guid("47d4c930-21fd-411d-807f-41fa5173c785"), "Description of Product 69", "Product 69", 98.08m },
                    { new Guid("481d9d53-eb83-4f99-a316-ec8ed88c2f89"), "Description of Product 707", "Product 707", 27.38m },
                    { new Guid("483e5286-b6aa-4537-b35a-8bff8a38d2a6"), "Description of Product 433", "Product 433", 17.21m },
                    { new Guid("48bcef05-e6bd-4dc4-96bb-971a3352b3d6"), "Description of Product 855", "Product 855", 57.24m },
                    { new Guid("49b00c18-71d2-4b1b-900f-3e34e8eb721f"), "Description of Product 441", "Product 441", 94.95m },
                    { new Guid("4a72fc9c-7083-46d1-9996-3293fb7d20e0"), "Description of Product 618", "Product 618", 96.36m },
                    { new Guid("4a7c0425-f532-422b-9c02-fb4fee570d0a"), "Description of Product 664", "Product 664", 79.76m },
                    { new Guid("4a8d1544-fcc1-4e28-b5bc-ad78a99e79bd"), "Description of Product 525", "Product 525", 34.94m },
                    { new Guid("4ab6277f-0fc5-496a-938c-1a459a7dcd1a"), "Description of Product 885", "Product 885", 1.57m },
                    { new Guid("4ab7569b-8604-405e-a8d8-48fc253dd579"), "Description of Product 319", "Product 319", 58.80m },
                    { new Guid("4abac99f-d0c9-40ba-ae4a-f9d4fe033274"), "Description of Product 344", "Product 344", 31.50m },
                    { new Guid("4abb1a71-e0c1-4eff-956b-ee039ecb3d14"), "Description of Product 403", "Product 403", 78.37m },
                    { new Guid("4b174b35-9a69-4a87-ace4-2079be86fe71"), "Description of Product 555", "Product 555", 74.35m },
                    { new Guid("4c43dd7d-953a-426d-95d0-7b42c7e4646b"), "Description of Product 685", "Product 685", 52.47m },
                    { new Guid("4c5efa90-54cb-4221-8b4d-458d4dcd7373"), "Description of Product 710", "Product 710", 14.44m },
                    { new Guid("4c6ccc78-13ec-4bd2-ba11-c5437592c48f"), "Description of Product 526", "Product 526", 63.75m },
                    { new Guid("4cd62df2-19df-4418-95d6-a3f153008142"), "Description of Product 171", "Product 171", 21.96m },
                    { new Guid("4d261b8c-d1e9-4217-8100-9ec1da22f911"), "Description of Product 173", "Product 173", 75.82m },
                    { new Guid("4d40e920-2baa-4dfd-85d0-07bc54205854"), "Description of Product 998", "Product 998", 91.97m },
                    { new Guid("4d456e54-068f-4a4e-a63e-9cc00d2cd80a"), "Description of Product 824", "Product 824", 59.30m },
                    { new Guid("4d5242f7-af2f-4e24-bc09-ac35c7345690"), "Description of Product 638", "Product 638", 59.56m },
                    { new Guid("4defce2c-063b-4291-b44f-418a92ebcf3e"), "Description of Product 736", "Product 736", 87.43m },
                    { new Guid("4df65a52-de80-4ad7-9fe3-bee407129e85"), "Description of Product 777", "Product 777", 38.52m },
                    { new Guid("4e185cb1-2f64-4181-91b1-c604d7b00321"), "Description of Product 683", "Product 683", 36.61m },
                    { new Guid("4e353a14-074f-4bbb-903e-bc2520819023"), "Description of Product 688", "Product 688", 70.65m },
                    { new Guid("4ee910d5-7982-4952-bffd-5506f2978860"), "Description of Product 959", "Product 959", 78.70m },
                    { new Guid("4ef731f3-f788-4b57-91e1-2dc424cb61ef"), "Description of Product 215", "Product 215", 58.87m },
                    { new Guid("4f0cd9fe-555c-40db-9ec3-e5bc0edf341a"), "Description of Product 404", "Product 404", 1.46m },
                    { new Guid("4f9f39b8-ee27-4bf2-82cc-0ba1579346ea"), "Description of Product 450", "Product 450", 11.70m },
                    { new Guid("4fd0162c-17af-4892-9d5a-0afa8ff13eb6"), "Description of Product 841", "Product 841", 66.50m },
                    { new Guid("50354946-53c2-4c01-9dbb-f8d8dbfb9ef7"), "Description of Product 238", "Product 238", 96.93m },
                    { new Guid("50dc6dd8-e7d9-48b7-bb80-b6dece235e79"), "Description of Product 107", "Product 107", 45.91m },
                    { new Guid("50eef3c3-68bd-43b7-96d1-27132c96c9db"), "Description of Product 713", "Product 713", 1.75m },
                    { new Guid("51150e2d-47c8-471c-8d39-cfc57b371140"), "Description of Product 751", "Product 751", 9.75m },
                    { new Guid("519712d5-8188-469f-9dd7-5a51f2f12263"), "Description of Product 822", "Product 822", 48.34m },
                    { new Guid("51c5b4c6-a585-405c-8b55-c89fac3b10bb"), "Description of Product 719", "Product 719", 69.58m },
                    { new Guid("51cfed92-f895-4aa0-86d4-3e88c228764f"), "Description of Product 54", "Product 54", 6.37m },
                    { new Guid("52a454e1-6629-49bd-a6a4-7cef9de254d2"), "Description of Product 31", "Product 31", 20.05m },
                    { new Guid("52b75d1f-bfbf-4b9a-88c8-4714f15ad773"), "Description of Product 1", "Product 1", 15.92m },
                    { new Guid("531157fb-044e-4be0-af50-62c166b3ad45"), "Description of Product 287", "Product 287", 80.88m },
                    { new Guid("53326572-c557-495c-b41f-09d65432446d"), "Description of Product 371", "Product 371", 15.39m },
                    { new Guid("54291e69-979f-484b-973a-adb5a9eb7135"), "Description of Product 577", "Product 577", 3.29m },
                    { new Guid("544cd845-a530-4d49-abfe-b7c3fea70581"), "Description of Product 533", "Product 533", 48.19m },
                    { new Guid("5539db9d-df55-44fa-9b54-2ce093df6a12"), "Description of Product 196", "Product 196", 13.35m },
                    { new Guid("555af53b-cca1-46aa-a7c0-45e21aaae35d"), "Description of Product 620", "Product 620", 28.68m },
                    { new Guid("561fc3d6-3761-4185-9d03-566e4d9cc823"), "Description of Product 499", "Product 499", 46.71m },
                    { new Guid("5676a997-5478-47d2-956d-95b86d3d6859"), "Description of Product 561", "Product 561", 60.52m },
                    { new Guid("568ad0a2-d4da-43fd-b432-8129906e0c3d"), "Description of Product 626", "Product 626", 29.55m },
                    { new Guid("56ab244e-0fba-4e59-bab5-f41805f1da97"), "Description of Product 999", "Product 999", 43.98m },
                    { new Guid("56d45af6-6676-4724-926e-0ac360e04eb9"), "Description of Product 401", "Product 401", 13.54m },
                    { new Guid("5829c7fd-d6ce-45a5-b4f8-c4ef4dfb846a"), "Description of Product 956", "Product 956", 82.11m },
                    { new Guid("583c4f27-cc25-42b3-a899-bc4ef59dc34d"), "Description of Product 80", "Product 80", 82.86m },
                    { new Guid("590dfc24-08d5-42f9-9845-96fc58d2132a"), "Description of Product 830", "Product 830", 81.38m },
                    { new Guid("592ea246-9716-41e0-9b0c-f551f2d06b9c"), "Description of Product 101", "Product 101", 92.36m },
                    { new Guid("594e9f5b-adf6-48c6-83f0-8e12b51ee28f"), "Description of Product 881", "Product 881", 94.35m },
                    { new Guid("596f0829-0735-412e-b346-a0ad8837d078"), "Description of Product 259", "Product 259", 47.44m },
                    { new Guid("597e9c5c-d71e-468f-8ae1-671005a48cad"), "Description of Product 6", "Product 6", 70.90m },
                    { new Guid("59cb37b8-4d33-401d-8b8e-0b5215a101e1"), "Description of Product 142", "Product 142", 18.12m },
                    { new Guid("59f4d903-b291-4c2b-8549-0065a2981c41"), "Description of Product 658", "Product 658", 73.83m },
                    { new Guid("5a4a0483-168c-4479-b919-d823d342b2f8"), "Description of Product 341", "Product 341", 7.57m },
                    { new Guid("5aaa298a-5374-429f-a14e-8f478b2e8438"), "Description of Product 430", "Product 430", 28.58m },
                    { new Guid("5abadb59-cef0-4d73-9c68-26ab24d97566"), "Description of Product 551", "Product 551", 65.81m },
                    { new Guid("5b1b3b71-ab83-4af2-aad4-7803fdbc6d4f"), "Description of Product 613", "Product 613", 91.01m },
                    { new Guid("5b37cbce-d5ba-46e8-8e43-38c2a278c624"), "Description of Product 146", "Product 146", 16.15m },
                    { new Guid("5b50829b-80bd-475e-85f7-83f6b044a718"), "Description of Product 955", "Product 955", 59.37m },
                    { new Guid("5b8d7a06-6809-4c82-9bab-723f39338f6a"), "Description of Product 966", "Product 966", 93.02m },
                    { new Guid("5b938577-e8e7-4c26-a7a2-5dc115579002"), "Description of Product 715", "Product 715", 53.18m },
                    { new Guid("5bdeaa20-239e-4c24-af84-360162ec3754"), "Description of Product 726", "Product 726", 70.46m },
                    { new Guid("5bee7d2d-bca9-4be4-9bbb-81b783652b8f"), "Description of Product 948", "Product 948", 96.29m },
                    { new Guid("5c11730c-2cc2-44b9-9ad2-7e63b5ed8477"), "Description of Product 115", "Product 115", 67.70m },
                    { new Guid("5c1bbfc9-b872-470b-b9c4-49642320690b"), "Description of Product 449", "Product 449", 42.97m },
                    { new Guid("5c568f79-73ec-40ed-9449-1f9672e3a2fd"), "Description of Product 833", "Product 833", 51.03m },
                    { new Guid("5c8cb082-d511-4ee3-94e5-1b89e7b1179e"), "Description of Product 874", "Product 874", 80.52m },
                    { new Guid("5cd416ce-47df-4def-8c1f-b244340b2c5f"), "Description of Product 675", "Product 675", 62.20m },
                    { new Guid("5db2aa75-8460-457d-b1f2-3089e3b366de"), "Description of Product 762", "Product 762", 31.16m },
                    { new Guid("5e048ab3-13ee-4419-a1bd-f8c3acc04cd3"), "Description of Product 282", "Product 282", 83.67m },
                    { new Guid("5e632f31-1ecb-45b4-891f-f0bbb8cb57ac"), "Description of Product 4", "Product 4", 55.62m },
                    { new Guid("5e6f799a-2249-434f-8177-7788e353f2b7"), "Description of Product 745", "Product 745", 65.81m },
                    { new Guid("5eba145f-f473-40c7-aadd-713e48de9c02"), "Description of Product 17", "Product 17", 94.16m },
                    { new Guid("5ee55ffb-2010-4903-99ce-8bc097e44bec"), "Description of Product 295", "Product 295", 82.31m },
                    { new Guid("5eef75bb-a554-40fe-91e4-169376ae38fd"), "Description of Product 820", "Product 820", 20.35m },
                    { new Guid("5f29060f-ba0b-4a36-b074-ba61fd47df71"), "Description of Product 201", "Product 201", 66.62m },
                    { new Guid("601e289c-85ab-4886-8f4f-91f5c6b35a78"), "Description of Product 884", "Product 884", 25.18m },
                    { new Guid("6028dc0d-f28c-4801-b6cd-b28d9e2107fb"), "Description of Product 455", "Product 455", 49.63m },
                    { new Guid("604c476b-704e-4648-b559-d9af1f2ca16c"), "Description of Product 42", "Product 42", 97.68m },
                    { new Guid("60dd2a55-9835-4a05-af66-5b5236a336e3"), "Description of Product 462", "Product 462", 68.20m },
                    { new Guid("61244bb1-19a7-4bfc-86d2-28288d93ea58"), "Description of Product 375", "Product 375", 59.76m },
                    { new Guid("6152a13e-649e-454d-9e94-683b254b6919"), "Description of Product 376", "Product 376", 93.88m },
                    { new Guid("6190133e-38dd-4865-80cb-8f7e05d5921d"), "Description of Product 980", "Product 980", 30.49m },
                    { new Guid("61d4b99d-9317-495b-ab8e-1acff64dd454"), "Description of Product 749", "Product 749", 45.90m },
                    { new Guid("61d6d05b-9463-44ea-aa80-674a2b183b57"), "Description of Product 770", "Product 770", 69.75m },
                    { new Guid("61e72f4b-4da3-47ea-8fd0-14f1b3b66e62"), "Description of Product 150", "Product 150", 90.96m },
                    { new Guid("62e29be4-0c1b-41a1-a697-4939b72396f7"), "Description of Product 431", "Product 431", 11.03m },
                    { new Guid("62f43c95-058e-4a92-bc16-c0207e780477"), "Description of Product 968", "Product 968", 63.83m },
                    { new Guid("62f6c88f-4662-43df-be5e-f1b9bbb1ede2"), "Description of Product 260", "Product 260", 81.91m },
                    { new Guid("6301ef4b-177c-4f97-8b10-7fc9a64cf1a0"), "Description of Product 594", "Product 594", 9.19m },
                    { new Guid("630f3019-7b37-4f4b-ab86-71e3205bf176"), "Description of Product 23", "Product 23", 60.78m },
                    { new Guid("63154918-c997-4e35-ad6e-1c5bc1b07b0f"), "Description of Product 310", "Product 310", 88.14m },
                    { new Guid("634648c5-d7d5-494f-9357-8065e98c6fc2"), "Description of Product 257", "Product 257", 66.18m },
                    { new Guid("638c5bd6-f3b4-4488-9bb5-5acb660101c3"), "Description of Product 216", "Product 216", 62.64m },
                    { new Guid("63bd0d56-23e4-44cc-a532-822f9ae81532"), "Description of Product 681", "Product 681", 6.94m },
                    { new Guid("63d2306e-e8ec-4709-b319-df559c5dc8f0"), "Description of Product 303", "Product 303", 30.94m },
                    { new Guid("63e5efa9-c028-4859-a84a-71c944868405"), "Description of Product 740", "Product 740", 67.80m },
                    { new Guid("6484e95b-89b0-4811-9b4c-b42bdd695f88"), "Description of Product 851", "Product 851", 63.38m },
                    { new Guid("65544684-03d1-46e7-a06f-5e24cec3b959"), "Description of Product 93", "Product 93", 46.63m },
                    { new Guid("65abf50d-d081-4bf8-b636-e2de9c5af068"), "Description of Product 650", "Product 650", 10.78m },
                    { new Guid("65c092f6-5dc4-49d0-acf6-c2f1ba23c865"), "Description of Product 901", "Product 901", 45.24m },
                    { new Guid("65fe4f23-1a97-41e4-b4bb-cec553de67e5"), "Description of Product 275", "Product 275", 25.89m },
                    { new Guid("66382663-a3cf-4d73-a27a-e33167b34cc6"), "Description of Product 15", "Product 15", 23.88m },
                    { new Guid("66ca0c5f-7a34-411f-8945-fdafbbf943aa"), "Description of Product 439", "Product 439", 85.41m },
                    { new Guid("66de71ad-2542-4d33-a69a-eae7a1c8acfc"), "Description of Product 459", "Product 459", 78.06m },
                    { new Guid("670ce409-522d-4ff3-a5d9-fda166cdca7c"), "Description of Product 256", "Product 256", 55.65m },
                    { new Guid("674e1360-bc20-48bb-b81b-51df44b8a8b5"), "Description of Product 400", "Product 400", 54.29m },
                    { new Guid("677cd29c-54eb-408c-8a9c-8b24dac80dde"), "Description of Product 628", "Product 628", 39.34m },
                    { new Guid("67adc95f-4546-47e1-93b4-1af3e668ef5f"), "Description of Product 188", "Product 188", 21.60m },
                    { new Guid("681f1e1a-2b37-4136-a790-b054db8c352c"), "Description of Product 679", "Product 679", 48.98m },
                    { new Guid("6838f80e-f55a-4d98-af02-78a4d76fd026"), "Description of Product 696", "Product 696", 57.42m },
                    { new Guid("684c3f30-d0eb-49cb-9b70-9307967b16df"), "Description of Product 27", "Product 27", 68.42m },
                    { new Guid("689e23b1-577d-4ab6-bb78-277cbb6fc6d7"), "Description of Product 322", "Product 322", 35.25m },
                    { new Guid("68e4f56f-643f-45b8-8ffa-9ef83a3bbd45"), "Description of Product 286", "Product 286", 69.17m },
                    { new Guid("69227c2c-d676-4829-9b58-8bac43691bce"), "Description of Product 860", "Product 860", 38.43m },
                    { new Guid("69788ce8-803c-406e-99f9-9a78d0442c95"), "Description of Product 252", "Product 252", 33.16m },
                    { new Guid("69b352c9-5901-49b6-a507-46e03ec2e499"), "Description of Product 539", "Product 539", 63.31m },
                    { new Guid("69f3a103-17f7-49e9-9ab6-634126abd716"), "Description of Product 581", "Product 581", 1.28m },
                    { new Guid("6a2bce7d-b004-41ed-abe3-62d11db0506c"), "Description of Product 199", "Product 199", 52.55m },
                    { new Guid("6a49725d-51d3-4e1c-a198-c2dbcd98ee4a"), "Description of Product 700", "Product 700", 29.12m },
                    { new Guid("6a50f437-de38-4a34-9023-ea5438a13f7d"), "Description of Product 815", "Product 815", 72.52m },
                    { new Guid("6a661b7e-2537-422a-aaa9-dd1a092de59b"), "Description of Product 758", "Product 758", 43.23m },
                    { new Guid("6a867021-91f0-427a-a058-e4695d71aaa7"), "Description of Product 821", "Product 821", 14.41m },
                    { new Guid("6b90dcf4-e1cb-4697-b7f6-a1b79abcf723"), "Description of Product 467", "Product 467", 62.93m },
                    { new Guid("6c370067-ac1e-4a48-ac18-d9b33fbce3be"), "Description of Product 654", "Product 654", 93.73m },
                    { new Guid("6cb1dd6b-7dd8-4d78-b2b7-a0d945549fb6"), "Description of Product 159", "Product 159", 86.06m },
                    { new Guid("6cb3584c-766d-4135-a9f1-da2071ec66be"), "Description of Product 271", "Product 271", 30.00m },
                    { new Guid("6ce25256-faad-4835-886b-e1b4aeaa9b8a"), "Description of Product 674", "Product 674", 9.62m },
                    { new Guid("6d020a4a-2487-4b15-b33f-b9b7819a0df3"), "Description of Product 343", "Product 343", 48.73m },
                    { new Guid("6e2fe8e9-7db8-4416-9a18-31d745a2c6ac"), "Description of Product 337", "Product 337", 15.86m },
                    { new Guid("6e3e5ac5-aee1-42ca-a0f6-8d5fd9bf5e9a"), "Description of Product 753", "Product 753", 87.08m },
                    { new Guid("6e8db616-0b8e-4c78-989f-071d1f5e27e7"), "Description of Product 772", "Product 772", 75.85m },
                    { new Guid("6ea1a5e1-cb10-4321-b9f3-ea532a76652c"), "Description of Product 157", "Product 157", 39.14m },
                    { new Guid("6ef468ae-64a3-45e7-b120-fb387b353cfb"), "Description of Product 846", "Product 846", 91.43m },
                    { new Guid("6f979132-bab9-4024-b410-e016482bb9ec"), "Description of Product 837", "Product 837", 31.41m },
                    { new Guid("6fb64771-88c7-454b-8e6a-98656010cec2"), "Description of Product 419", "Product 419", 53.64m },
                    { new Guid("6fd6c2c9-b244-46bb-aa5d-f283b949742d"), "Description of Product 978", "Product 978", 71.68m },
                    { new Guid("70247a9b-9ffc-429f-aeba-7131df9cd309"), "Description of Product 803", "Product 803", 94.91m },
                    { new Guid("702739bb-a216-4526-a8e8-a9fcd3622724"), "Description of Product 763", "Product 763", 79.71m },
                    { new Guid("704b4d07-235b-49a5-a997-f1c49041222b"), "Description of Product 601", "Product 601", 9.09m },
                    { new Guid("70aa32e0-91a0-4b05-90b2-92191e2a03b9"), "Description of Product 221", "Product 221", 80.69m },
                    { new Guid("7118a5c1-0316-4566-b66b-e8e062968f50"), "Description of Product 211", "Product 211", 30.72m },
                    { new Guid("712e0559-b4a5-46fb-843a-da8a76f293a5"), "Description of Product 557", "Product 557", 34.94m },
                    { new Guid("71374165-9b18-4946-803b-46fbea69022c"), "Description of Product 761", "Product 761", 54.43m },
                    { new Guid("719c09d9-6f62-4eb4-b20d-4dce848a7e39"), "Description of Product 445", "Product 445", 72.23m },
                    { new Guid("71d1de38-2ed8-4de9-859f-84074e9788e1"), "Description of Product 386", "Product 386", 92.51m },
                    { new Guid("71eb0844-b6cc-4b86-8132-cfb6410d1fc4"), "Description of Product 940", "Product 940", 81.33m },
                    { new Guid("71fb1f39-dd7c-408a-97bb-e728d71b3ee1"), "Description of Product 906", "Product 906", 79.92m },
                    { new Guid("71ff8301-c820-4d96-9716-c9f6d1b69d41"), "Description of Product 600", "Product 600", 46.42m },
                    { new Guid("724fd5ad-7cd2-4776-85de-e2a5227ed488"), "Description of Product 508", "Product 508", 1.43m },
                    { new Guid("732d6fff-46cb-4777-a37c-67eb5f56d432"), "Description of Product 512", "Product 512", 3.47m },
                    { new Guid("73a4c534-ba2b-4f1b-990b-be6ee0beb542"), "Description of Product 590", "Product 590", 91.37m },
                    { new Guid("741a6417-41e9-496b-a106-1b546c9ef68c"), "Description of Product 887", "Product 887", 12.52m },
                    { new Guid("74b8c654-bda2-41c4-b699-35af6f0140f7"), "Description of Product 558", "Product 558", 74.67m },
                    { new Guid("74c9fc65-c1c0-4bbc-a7fa-39625939696f"), "Description of Product 856", "Product 856", 6.68m },
                    { new Guid("74cd9c80-d33e-4ebe-838e-c8aebcdd043c"), "Description of Product 605", "Product 605", 65.42m },
                    { new Guid("74ea780b-f1a8-410b-bb09-74e747ae5f84"), "Description of Product 249", "Product 249", 16.87m },
                    { new Guid("761e5e9c-7796-4da0-8628-fb39848053f6"), "Description of Product 152", "Product 152", 65.24m },
                    { new Guid("7646a238-f674-4e56-b7d7-d68a0215aec4"), "Description of Product 110", "Product 110", 14.51m },
                    { new Guid("76cce0fd-84b8-4923-930c-7d64ea2c2d88"), "Description of Product 989", "Product 989", 88.84m },
                    { new Guid("76f089c1-ce7d-4a94-bcb8-0d872c71d587"), "Description of Product 553", "Product 553", 63.96m },
                    { new Guid("76fdd0fe-41ae-4cb2-80b6-fc8a953b4913"), "Description of Product 893", "Product 893", 35.39m },
                    { new Guid("76ffab10-d343-4030-b2cf-7d3ec94fb307"), "Description of Product 264", "Product 264", 2.11m },
                    { new Guid("7728df59-bea9-4553-ac78-e0537dc73c01"), "Description of Product 29", "Product 29", 75.52m },
                    { new Guid("777f1ef6-9feb-4135-aa5a-d9534f9c1071"), "Description of Product 739", "Product 739", 68.74m },
                    { new Guid("77c49ffb-7c0f-45c1-997a-8388306ec391"), "Description of Product 583", "Product 583", 6.56m },
                    { new Guid("786a3e6b-b050-4eaa-9114-c8d08562169b"), "Description of Product 480", "Product 480", 52.46m },
                    { new Guid("7884f68a-e7cb-47bc-8255-e4ec04416296"), "Description of Product 767", "Product 767", 31.59m },
                    { new Guid("7884f7c9-cf8e-4d32-922e-5bf01c391d74"), "Description of Product 580", "Product 580", 40.49m },
                    { new Guid("78855bda-2119-4582-85cf-8707c9a2286a"), "Description of Product 699", "Product 699", 9.42m },
                    { new Guid("789f7613-46c8-48c7-ae51-e670428a9dbc"), "Description of Product 354", "Product 354", 41.83m },
                    { new Guid("78aa4a3d-fa56-4ac9-83f1-5a30dd125325"), "Description of Product 394", "Product 394", 81.20m },
                    { new Guid("7913a97e-7321-462a-987e-b47dc3045768"), "Description of Product 718", "Product 718", 7.51m },
                    { new Guid("7949718d-689e-4689-a8a5-851da52690a0"), "Description of Product 690", "Product 690", 97.57m },
                    { new Guid("796ba519-667f-4c21-a899-f023d50e63af"), "Description of Product 963", "Product 963", 62.19m },
                    { new Guid("798cf4a3-1d3f-411e-8473-2783b3d40267"), "Description of Product 488", "Product 488", 24.55m },
                    { new Guid("79cfab31-b991-4df3-8427-aedfebd74323"), "Description of Product 440", "Product 440", 99.02m },
                    { new Guid("79d4528b-82ea-4a48-903a-8a838eda2072"), "Description of Product 46", "Product 46", 56.13m },
                    { new Guid("7a1fd0d5-7285-4cb9-8ea4-0b2f56a34697"), "Description of Product 218", "Product 218", 39.36m },
                    { new Guid("7a681b70-f78c-4a2b-a45a-748fc4fad42f"), "Description of Product 94", "Product 94", 32.10m },
                    { new Guid("7b1a88b1-bcd0-4167-8499-92774f102cc1"), "Description of Product 14", "Product 14", 58.48m },
                    { new Guid("7b54b86e-2846-441d-a798-d57028c94fff"), "Description of Product 379", "Product 379", 98.92m },
                    { new Guid("7b746fd1-e39e-4d15-99a0-015d47c95b79"), "Description of Product 988", "Product 988", 27.23m },
                    { new Guid("7ba3ded0-58c1-4fff-add4-1703991e406c"), "Description of Product 902", "Product 902", 45.65m },
                    { new Guid("7c8cac84-a175-4562-8907-39ea94ab6ee6"), "Description of Product 657", "Product 657", 50.42m },
                    { new Guid("7cc48306-6302-4c83-a062-0341bf7bb757"), "Description of Product 619", "Product 619", 15.74m },
                    { new Guid("7da8909f-6161-4bf0-8832-db578d5e98a7"), "Description of Product 83", "Product 83", 24.44m },
                    { new Guid("7dd60a2d-0092-4f69-ab15-20e77f201f9f"), "Description of Product 547", "Product 547", 34.72m },
                    { new Guid("7e2992a8-1725-44df-bcee-7cb1b6ea4493"), "Description of Product 768", "Product 768", 61.74m },
                    { new Guid("7e52aa16-ddc1-46bc-9dec-25389d1e1dab"), "Description of Product 267", "Product 267", 57.51m },
                    { new Guid("7e7903fc-be2b-42dc-bd1b-2937b8eba51d"), "Description of Product 773", "Product 773", 83.67m },
                    { new Guid("7e81b3d7-dd78-4a63-893a-40e29362e85d"), "Description of Product 464", "Product 464", 55.52m },
                    { new Guid("7e935fcb-9c15-41a9-ad33-21ee5bdf149a"), "Description of Product 589", "Product 589", 85.17m },
                    { new Guid("7e9ac308-1610-4fc3-882f-c40eb1efa62f"), "Description of Product 864", "Product 864", 22.19m },
                    { new Guid("7edaa7cf-61f7-4097-a4d4-d5fb6ff244a9"), "Description of Product 71", "Product 71", 83.91m },
                    { new Guid("7ee6ffce-3f0f-4418-92fb-cb4559465e3c"), "Description of Product 493", "Product 493", 1.78m },
                    { new Guid("7f45cd0d-d510-4bc5-9d9e-5ecc199534ca"), "Description of Product 95", "Product 95", 15.86m },
                    { new Guid("7f66089d-2976-4485-8f07-eac50c94c674"), "Description of Product 475", "Product 475", 60.04m },
                    { new Guid("7f8a8c97-3d5e-49be-8dd8-cc8f55fc99c6"), "Description of Product 908", "Product 908", 75.56m },
                    { new Guid("8023b2d5-2e3d-4986-a79a-83dc39ff6ce5"), "Description of Product 166", "Product 166", 89.65m },
                    { new Guid("80631c13-ac50-406c-bb6f-89781084488e"), "Description of Product 350", "Product 350", 90.07m },
                    { new Guid("81382456-c43f-4928-b5b1-5fa58cbc69da"), "Description of Product 845", "Product 845", 5.91m },
                    { new Guid("81a9340d-ef3e-48d6-9082-cb0eb77b1bc1"), "Description of Product 975", "Product 975", 53.25m },
                    { new Guid("81b90efb-ce58-45e5-bbe1-523bf8afbe25"), "Description of Product 545", "Product 545", 38.84m },
                    { new Guid("81be888c-b685-4991-bbe2-318d3a673b15"), "Description of Product 634", "Product 634", 56.85m },
                    { new Guid("820c7f8d-d025-424a-9b23-6f8215b9badb"), "Description of Product 413", "Product 413", 53.67m },
                    { new Guid("82390860-92c5-42f2-bb51-c45e64a31fa9"), "Description of Product 20", "Product 20", 25.28m },
                    { new Guid("826a1684-7cda-4b00-9111-140833ba89e0"), "Description of Product 122", "Product 122", 90.59m },
                    { new Guid("82b01493-647a-4c23-98ad-f5b40efc502a"), "Description of Product 792", "Product 792", 61.35m },
                    { new Guid("82c0c341-4e88-4629-b0e0-bf170726c4db"), "Description of Product 109", "Product 109", 1.84m },
                    { new Guid("82c861bf-2faf-4b86-b9c7-ee6336175332"), "Description of Product 596", "Product 596", 15.97m },
                    { new Guid("83c66835-36d5-41ea-980c-81896494c815"), "Description of Product 937", "Product 937", 45.86m },
                    { new Guid("840777fb-5eaf-446c-a2c7-ae40e43f232e"), "Description of Product 965", "Product 965", 70.04m },
                    { new Guid("84c1ac36-c83f-4ce5-a445-c4fc1517bbaf"), "Description of Product 518", "Product 518", 38.36m },
                    { new Guid("853731a8-71cd-4bf0-8bf6-f256d52198a8"), "Description of Product 108", "Product 108", 35.86m },
                    { new Guid("8563f746-5598-4b18-a3b7-6b8857b76ffa"), "Description of Product 85", "Product 85", 55.44m },
                    { new Guid("85a4bb75-78f9-4454-b4dd-53e4453a61d1"), "Description of Product 812", "Product 812", 40.62m },
                    { new Guid("85bd5ba2-04ea-491b-8265-4d6d3368e3e5"), "Description of Product 293", "Product 293", 29.67m },
                    { new Guid("865796a2-2f2d-4eb3-8b1b-685b874a6833"), "Description of Product 599", "Product 599", 99.66m },
                    { new Guid("865d6ac3-08f1-438a-b903-2e894a6aa93e"), "Description of Product 522", "Product 522", 48.28m },
                    { new Guid("865fdb16-8159-47d6-bb40-94f66ced1820"), "Description of Product 141", "Product 141", 32.22m },
                    { new Guid("8730180a-52ba-41c7-8b7b-8254a09ca852"), "Description of Product 536", "Product 536", 52.96m },
                    { new Guid("87313605-2467-4a87-b091-cc4d2238f126"), "Description of Product 817", "Product 817", 77.00m },
                    { new Guid("87566aff-44fa-4bb8-a0d1-4d22089f14a1"), "Description of Product 808", "Product 808", 76.10m },
                    { new Guid("876217b3-a987-4ee5-811b-917962ca07db"), "Description of Product 426", "Product 426", 47.93m },
                    { new Guid("878908fb-a389-4575-a673-20be5a2d917b"), "Description of Product 865", "Product 865", 97.46m },
                    { new Guid("8794a9fd-95b8-4270-add8-287236bf4057"), "Description of Product 47", "Product 47", 66.48m },
                    { new Guid("87c25166-4562-47e5-8e02-34323abcef3e"), "Description of Product 946", "Product 946", 73.13m },
                    { new Guid("87d4ad3f-bbd1-4048-9a67-691359c74fff"), "Description of Product 857", "Product 857", 84.51m },
                    { new Guid("87d8a606-f439-4410-8920-487abf800a3b"), "Description of Product 669", "Product 669", 64.24m },
                    { new Guid("88668d7c-e7cd-4775-9d57-0fd0c9776e47"), "Description of Product 878", "Product 878", 31.42m },
                    { new Guid("88a1e7dd-2d6f-41ed-99df-39ad8c71a5a8"), "Description of Product 535", "Product 535", 75.71m },
                    { new Guid("8941849f-38e1-4e8b-b59d-0433b33a1c8f"), "Description of Product 399", "Product 399", 25.64m },
                    { new Guid("89dfda1a-2c8e-49c2-95f7-d0d006a0f754"), "Description of Product 796", "Product 796", 17.32m },
                    { new Guid("8a45af43-9557-4218-a82e-ed777d0f5d3d"), "Description of Product 367", "Product 367", 4.09m },
                    { new Guid("8a71a552-c5b5-4cb6-8d81-913ec71a603c"), "Description of Product 842", "Product 842", 46.81m },
                    { new Guid("8ad852cc-91db-4d53-8d7d-037105949488"), "Description of Product 219", "Product 219", 98.57m },
                    { new Guid("8b0b3df0-0329-4e28-a587-dd656bd647cc"), "Description of Product 779", "Product 779", 87.54m },
                    { new Guid("8b0c6988-a418-4b27-8fc6-048fe81d5a2d"), "Description of Product 944", "Product 944", 62.26m },
                    { new Guid("8b0fba5f-b82b-4a04-b5a2-7cda4148e940"), "Description of Product 802", "Product 802", 99.35m },
                    { new Guid("8baf266a-f998-4926-b193-16c1843377b6"), "Description of Product 847", "Product 847", 30.12m },
                    { new Guid("8bc7a6dd-0f53-4033-8804-f7c2be194cde"), "Description of Product 574", "Product 574", 3.42m },
                    { new Guid("8c896bb1-0eb0-4dd6-89c1-4f4126e06ead"), "Description of Product 474", "Product 474", 91.18m },
                    { new Guid("8ca453c0-5d2d-4dcf-8eba-1a8a0aef0eea"), "Description of Product 502", "Product 502", 30.08m },
                    { new Guid("8ca96fd0-3774-42c0-9d6e-18dd875315cb"), "Description of Product 64", "Product 64", 51.13m },
                    { new Guid("8cf399fb-f2e3-48c5-8f82-188132cc7cd3"), "Description of Product 801", "Product 801", 68.69m },
                    { new Guid("8d50450e-9346-474f-b105-5393f3183f34"), "Description of Product 198", "Product 198", 80.94m },
                    { new Guid("8ddead13-8b78-4e63-b7cd-a2c5f0a54b70"), "Description of Product 839", "Product 839", 80.76m },
                    { new Guid("8e0df7c1-58ce-4cc9-9dda-e2361dea7455"), "Description of Product 179", "Product 179", 48.15m },
                    { new Guid("8e5f18ca-b69c-40f9-bb5a-43393b93caba"), "Description of Product 849", "Product 849", 15.70m },
                    { new Guid("8e6b02a9-b557-4c4b-8efa-23158b72ddf8"), "Description of Product 814", "Product 814", 7.15m },
                    { new Guid("8eafa7f6-2a50-4464-b90f-4ee4044b52f5"), "Description of Product 311", "Product 311", 45.85m },
                    { new Guid("8f41bd31-6729-4b19-9458-78ca6b488799"), "Description of Product 131", "Product 131", 78.43m },
                    { new Guid("9008898a-6854-47f7-b6cd-05f9988b3f34"), "Description of Product 653", "Product 653", 84.45m },
                    { new Guid("902dfca0-7aae-4edc-ba88-3f875c225ae9"), "Description of Product 92", "Product 92", 6.81m },
                    { new Guid("9039bfd2-1776-4a59-927b-4ac2b6601eb4"), "Description of Product 360", "Product 360", 79.23m },
                    { new Guid("905d1bae-c54d-4c12-bfc2-964e29d3a950"), "Description of Product 408", "Product 408", 72.65m },
                    { new Guid("905fc9f0-80a5-48b5-b975-62481824229d"), "Description of Product 615", "Product 615", 47.25m },
                    { new Guid("9073b896-5a91-4786-a412-20b8a7a4ecbf"), "Description of Product 285", "Product 285", 23.73m },
                    { new Guid("90c422f1-6d7c-43de-82bc-731b9d82388f"), "Description of Product 334", "Product 334", 63.00m },
                    { new Guid("90da61c6-1727-49af-8ae8-0c8ce9cfa8f1"), "Description of Product 16", "Product 16", 28.89m },
                    { new Guid("911ca2e1-8779-4e4f-b5ac-643b55497bbb"), "Description of Product 507", "Product 507", 42.24m },
                    { new Guid("9126b6a7-a7b3-4259-b068-61026c76a094"), "Description of Product 128", "Product 128", 63.26m },
                    { new Guid("9165ce54-69e8-46e6-950b-e1415c74b3c5"), "Description of Product 183", "Product 183", 21.36m },
                    { new Guid("91853e1e-c9c2-41d9-9b77-a30f4eefe865"), "Description of Product 10", "Product 10", 3.20m },
                    { new Guid("91e2a24b-c79c-4a5a-b00a-c7a30b1c11b6"), "Description of Product 66", "Product 66", 66.39m },
                    { new Guid("92471b17-ca99-4a19-b6af-59b944ecbc7b"), "Description of Product 866", "Product 866", 58.75m },
                    { new Guid("924ff903-167b-4f8b-a4f9-b5ed696546b0"), "Description of Product 77", "Product 77", 88.60m },
                    { new Guid("9268823e-37f9-436c-bc7b-5dbb548d114a"), "Description of Product 332", "Product 332", 38.79m },
                    { new Guid("926dd1c6-5476-4f81-a669-f7dff4ada9ac"), "Description of Product 532", "Product 532", 80.62m },
                    { new Guid("93188b0b-0791-476c-8420-3fb1d9959ee2"), "Description of Product 365", "Product 365", 66.83m },
                    { new Guid("93642a38-c448-482d-9deb-de7300e5161c"), "Description of Product 124", "Product 124", 6.33m },
                    { new Guid("936efd14-97f5-41c8-a403-2cead8de191a"), "Description of Product 964", "Product 964", 12.38m },
                    { new Guid("93b2434a-dbb6-437e-88bb-a32a125f7b5c"), "Description of Product 162", "Product 162", 48.29m },
                    { new Guid("93c49b6d-1298-4f1d-b10a-037c3870f002"), "Description of Product 550", "Product 550", 51.72m },
                    { new Guid("93c4a3d7-ea23-4a9a-a776-83fb4db0e830"), "Description of Product 554", "Product 554", 66.32m },
                    { new Guid("9422c6be-e44e-4b55-8080-aadd437c375e"), "Description of Product 254", "Product 254", 68.34m },
                    { new Guid("9441ff30-4d6b-471a-885d-afaffdf9d891"), "Description of Product 189", "Product 189", 84.03m },
                    { new Guid("94d63b81-a1b7-4f27-bb21-de8ea3274942"), "Description of Product 492", "Product 492", 25.52m },
                    { new Guid("94df9105-b2ac-4aeb-a018-7b91bc4e2de4"), "Description of Product 789", "Product 789", 23.97m },
                    { new Guid("95446d63-a163-4261-a522-ea07ae8c4222"), "Description of Product 359", "Product 359", 87.29m },
                    { new Guid("96446c41-d73c-462d-8305-934a06324c48"), "Description of Product 147", "Product 147", 65.59m },
                    { new Guid("9684fc0c-9c2a-43f0-b70b-0a27cd31ec04"), "Description of Product 520", "Product 520", 35.12m },
                    { new Guid("96c8009d-d875-40bf-8449-887d9dc78db1"), "Description of Product 487", "Product 487", 21.93m },
                    { new Guid("971e8826-0fe6-4665-8c03-63bdbf1b389d"), "Description of Product 800", "Product 800", 3.45m },
                    { new Guid("97fb203a-8223-4692-9d85-0582174bc856"), "Description of Product 457", "Product 457", 41.62m },
                    { new Guid("9814303f-8a9f-4c4f-8799-826ddf5e4763"), "Description of Product 428", "Product 428", 53.09m },
                    { new Guid("98722d30-f30e-449a-87ed-b5c529a003d5"), "Description of Product 931", "Product 931", 37.39m },
                    { new Guid("98733858-bbd1-47df-8e94-baf67ddaf314"), "Description of Product 366", "Product 366", 58.44m },
                    { new Guid("98aa8541-dd26-48aa-b474-6c591f400235"), "Description of Product 939", "Product 939", 12.43m },
                    { new Guid("98e93f91-a002-480d-a349-2120943d75cb"), "Description of Product 818", "Product 818", 26.65m },
                    { new Guid("98ebf3b2-742e-4edb-bac3-f774a4179a8c"), "Description of Product 871", "Product 871", 24.02m },
                    { new Guid("99399d56-6bbf-4760-ab85-5c14a7eac1e6"), "Description of Product 396", "Product 396", 42.76m },
                    { new Guid("995cfad1-0630-47bb-912e-817cdbde2457"), "Description of Product 155", "Product 155", 80.97m },
                    { new Guid("997c7913-b3bf-4995-a14b-e01a40387a4d"), "Description of Product 160", "Product 160", 66.61m },
                    { new Guid("99837bad-5b4e-4e3e-8610-865c3d8f70f4"), "Description of Product 395", "Product 395", 50.96m },
                    { new Guid("99bd39a5-75f8-45c2-aa57-957e39882ef9"), "Description of Product 991", "Product 991", 55.56m },
                    { new Guid("99bd5a77-5779-4804-8d0e-069710f89205"), "Description of Product 250", "Product 250", 93.53m },
                    { new Guid("99d72060-6009-46f0-a2d2-e199bce3a3a3"), "Description of Product 858", "Product 858", 48.65m },
                    { new Guid("99e02870-04fd-45db-9f85-f0d387bf59b8"), "Description of Product 660", "Product 660", 17.74m },
                    { new Guid("9a14c545-d635-4acf-925a-d8df3da4bade"), "Description of Product 225", "Product 225", 21.92m },
                    { new Guid("9a5db2f2-43b2-47ff-b174-9fb9a04e305a"), "Description of Product 757", "Product 757", 23.01m },
                    { new Guid("9a669fe2-6e4d-4b60-82c0-bc538a5aa954"), "Description of Product 996", "Product 996", 82.04m },
                    { new Guid("9a8bbba6-f232-44a7-9d73-9666deeb75d6"), "Description of Product 393", "Product 393", 45.10m },
                    { new Guid("9a9b394e-501b-4f87-a255-d94d6ce1796a"), "Description of Product 325", "Product 325", 43.67m },
                    { new Guid("9aa92606-1877-4469-8787-762a447660ea"), "Description of Product 385", "Product 385", 67.04m },
                    { new Guid("9ac09f03-6fa8-4be4-8a58-6477589bf41f"), "Description of Product 451", "Product 451", 2.14m },
                    { new Guid("9b1b0e41-dae1-4f78-ba73-607f1f78b007"), "Description of Product 491", "Product 491", 79.59m },
                    { new Guid("9b1bb160-c346-4cc1-b403-c1b6ffb89007"), "Description of Product 709", "Product 709", 31.60m },
                    { new Guid("9b60b64f-97c9-426f-bf05-19505d87fa99"), "Description of Product 918", "Product 918", 22.73m },
                    { new Guid("9b891fc6-6b92-4250-a20d-8880c512ec83"), "Description of Product 694", "Product 694", 5.10m },
                    { new Guid("9bc812bc-78e3-42ee-b7d6-a6dda00461c9"), "Description of Product 954", "Product 954", 50.47m },
                    { new Guid("9bcbfb93-0519-4833-b850-c34619a898e0"), "Description of Product 114", "Product 114", 49.44m },
                    { new Guid("9bcfa2df-5cab-4283-bcb8-259ae8601e8e"), "Description of Product 438", "Product 438", 32.74m },
                    { new Guid("9c51b764-53ed-4e3e-a8e5-44105fe589e9"), "Description of Product 648", "Product 648", 29.13m },
                    { new Guid("9d0b4012-f2ee-4e68-b95e-a799fbd5e9b6"), "Description of Product 637", "Product 637", 89.42m },
                    { new Guid("9d6a223f-a820-40de-81ea-52c239dd0a5e"), "Description of Product 778", "Product 778", 86.30m },
                    { new Guid("9d6e4d0c-f5b9-483c-8a62-94903a84c5d0"), "Description of Product 36", "Product 36", 3.09m },
                    { new Guid("9d775ac5-3a0e-46f6-af73-7edb09ff8532"), "Description of Product 299", "Product 299", 35.76m },
                    { new Guid("9da9d6f5-4986-43af-8604-6550b910c079"), "Description of Product 247", "Product 247", 77.05m },
                    { new Guid("9e2eff85-22b8-4bef-b37d-73bea14e34ae"), "Description of Product 111", "Product 111", 33.27m },
                    { new Guid("9eb7ef07-b48e-4fe8-a236-c59b9491135b"), "Description of Product 986", "Product 986", 85.39m },
                    { new Guid("9ebb2e7e-9a3a-4def-ab20-03b257739405"), "Description of Product 237", "Product 237", 14.50m },
                    { new Guid("9f03dded-5e9b-467a-8992-adf092a30725"), "Description of Product 391", "Product 391", 86.66m },
                    { new Guid("9f1e6a4e-03ab-4a70-a792-c95ff39ed050"), "Description of Product 291", "Product 291", 41.72m },
                    { new Guid("9f1e83f1-dcd8-489e-bbe0-a6561d563808"), "Description of Product 678", "Product 678", 80.09m },
                    { new Guid("9f422c24-66e5-4fe3-848b-2da79c2e0430"), "Description of Product 914", "Product 914", 47.25m },
                    { new Guid("9f54c576-7cac-4344-ade6-2498e1b524c5"), "Description of Product 810", "Product 810", 94.31m },
                    { new Guid("9f88d572-5bac-448d-a220-1dd2cc63f73e"), "Description of Product 597", "Product 597", 11.40m },
                    { new Guid("9fd548dd-98b0-4919-962e-9ce836d82322"), "Description of Product 624", "Product 624", 58.43m },
                    { new Guid("9fd9534c-816f-4552-b98f-a4d7ab8fed7c"), "Description of Product 798", "Product 798", 66.59m },
                    { new Guid("a0013a7d-7814-46de-8a3e-a46b7067457a"), "Description of Product 632", "Product 632", 59.82m },
                    { new Guid("a02a6149-1b92-4ba0-b9b7-4eb2574853a7"), "Description of Product 511", "Product 511", 22.13m },
                    { new Guid("a04998f6-49b9-4796-9f9e-74af7395ce97"), "Description of Product 565", "Product 565", 9.13m },
                    { new Guid("a0646105-a6ea-4c06-a050-bd0c876ce9d4"), "Description of Product 352", "Product 352", 43.32m },
                    { new Guid("a0829162-f9b7-43df-bbbb-5dc46d957417"), "Description of Product 949", "Product 949", 41.27m },
                    { new Guid("a0d69d5b-fbd6-4b0e-b173-c1817cfb231c"), "Description of Product 879", "Product 879", 12.76m },
                    { new Guid("a0d7cb9a-36e7-4c30-954d-d2856ea09df3"), "Description of Product 208", "Product 208", 63.84m },
                    { new Guid("a11e131a-d3e0-4080-ba6e-b4645c2a98a9"), "Description of Product 9", "Product 9", 63.82m },
                    { new Guid("a132f1bc-943c-4a2e-8a5b-d087229f6b56"), "Description of Product 104", "Product 104", 12.33m },
                    { new Guid("a1507047-5019-4d74-bf94-a8d5129c100c"), "Description of Product 452", "Product 452", 73.91m },
                    { new Guid("a1984bfb-16b8-4d8b-b21f-c07105a5cab6"), "Description of Product 776", "Product 776", 2.70m },
                    { new Guid("a1a31114-5e3c-4a75-a28d-3fe334d7a956"), "Description of Product 663", "Product 663", 1.69m },
                    { new Guid("a1af1e7e-17e2-4f83-87f9-8ad1a9362209"), "Description of Product 485", "Product 485", 80.54m },
                    { new Guid("a2294e35-d339-4f97-b7f7-1172d120808d"), "Description of Product 829", "Product 829", 4.89m },
                    { new Guid("a23c4995-f7ef-47e4-ae1e-70b2c96ae9d6"), "Description of Product 861", "Product 861", 83.49m },
                    { new Guid("a24c022a-4de3-432e-89f7-0237ba033fbc"), "Description of Product 593", "Product 593", 51.37m },
                    { new Guid("a2603ed5-dc69-49ea-9f74-1899ebb854c2"), "Description of Product 760", "Product 760", 85.76m },
                    { new Guid("a31e402f-c325-4e07-bc24-d210645639f1"), "Description of Product 732", "Product 732", 51.67m },
                    { new Guid("a32f3e71-ed70-45d3-9246-bfcbb194c7fe"), "Description of Product 86", "Product 86", 90.88m },
                    { new Guid("a33a2b9b-f3a2-4a09-9d6f-3189dc14a791"), "Description of Product 251", "Product 251", 3.20m },
                    { new Guid("a34da11a-1bff-4e34-a664-a572a7b9a5d1"), "Description of Product 503", "Product 503", 50.85m },
                    { new Guid("a3b3fd53-1596-4e2f-b042-6fb2f636fb5d"), "Description of Product 759", "Product 759", 70.74m },
                    { new Guid("a3b9d96c-fc73-40b8-86ac-dd8b726541b4"), "Description of Product 642", "Product 642", 41.86m },
                    { new Guid("a3ed22fb-d331-49be-8043-74550f352e05"), "Description of Product 747", "Product 747", 21.13m },
                    { new Guid("a3f8c9ea-3300-4ea1-ad23-b2c96a8dde94"), "Description of Product 269", "Product 269", 98.04m },
                    { new Guid("a47c2682-f5be-4aff-96e0-ff818391fca4"), "Description of Product 432", "Product 432", 94.28m },
                    { new Guid("a4db058f-6f80-41f0-bebc-9332c4db1980"), "Description of Product 859", "Product 859", 12.47m },
                    { new Guid("a50f2b76-c17d-4151-9dfc-ba76d83aa83b"), "Description of Product 414", "Product 414", 25.00m },
                    { new Guid("a51838e0-6cfe-47e9-94a4-a5d8105dd405"), "Description of Product 263", "Product 263", 84.78m },
                    { new Guid("a538f494-5391-4bff-a8d2-ac355583ba04"), "Description of Product 826", "Product 826", 54.71m },
                    { new Guid("a5913c12-c0d3-4640-83c0-457f415ebfd6"), "Description of Product 314", "Product 314", 41.33m },
                    { new Guid("a5b67dca-80a4-4a0b-9f77-eee9c878291d"), "Description of Product 831", "Product 831", 76.11m },
                    { new Guid("a5be9347-ead8-404b-a2dd-96ecdad51f2e"), "Description of Product 90", "Product 90", 80.30m },
                    { new Guid("a5d9f796-d4fc-437a-afdd-c468ee9efd9c"), "Description of Product 205", "Product 205", 22.68m },
                    { new Guid("a64cf12f-ff51-4858-aba8-cbc7723f186c"), "Description of Product 273", "Product 273", 64.93m },
                    { new Guid("a664baa6-e5c7-4a2e-932a-847bb2963e7d"), "Description of Product 486", "Product 486", 75.11m },
                    { new Guid("a6b30548-6a76-4617-9d15-a323a423b206"), "Description of Product 869", "Product 869", 40.81m },
                    { new Guid("a6d9436f-f98e-477a-bf38-2b9d5b053ec9"), "Description of Product 165", "Product 165", 41.71m },
                    { new Guid("a70c5e9d-3773-45f7-bd87-071983829c55"), "Description of Product 809", "Product 809", 93.13m },
                    { new Guid("a728a032-dbc5-4233-9080-e6dac8651620"), "Description of Product 30", "Product 30", 77.68m },
                    { new Guid("a7d4e5ff-3736-44e1-95d7-a82d9f115519"), "Description of Product 380", "Product 380", 69.59m },
                    { new Guid("a806a3e9-5ded-4af5-bf5c-e4374e560035"), "Description of Product 471", "Product 471", 78.08m },
                    { new Guid("a85011ac-b7f4-4a3f-a23b-cd59dee0d7e0"), "Description of Product 363", "Product 363", 60.23m },
                    { new Guid("a8585f9c-f843-48a6-8b18-3f3eaba22115"), "Description of Product 327", "Product 327", 46.41m },
                    { new Guid("a8834c72-f7ab-4df4-8ebe-66c3e4e6a4ca"), "Description of Product 169", "Product 169", 78.69m },
                    { new Guid("a89f1faf-008b-4711-b2f0-f420d1641bed"), "Description of Product 614", "Product 614", 66.40m },
                    { new Guid("a91f32a6-e41e-4b0c-a186-9cd5791629bc"), "Description of Product 598", "Product 598", 51.49m },
                    { new Guid("aa42ab59-c4dd-4ac7-ab94-047638afc9e4"), "Description of Product 932", "Product 932", 23.14m },
                    { new Guid("aa53a84b-bc34-4d05-a3b5-2a071c543e40"), "Description of Product 339", "Product 339", 17.62m },
                    { new Guid("aab81f6c-ef2c-48b5-b27e-90c223418017"), "Description of Product 875", "Product 875", 76.35m },
                    { new Guid("ab0bf74e-7472-4b18-95ec-32b94a895b84"), "Description of Product 261", "Product 261", 80.78m },
                    { new Guid("ab2514e6-24e1-4d2f-895f-c19b5be549ff"), "Description of Product 915", "Product 915", 76.25m },
                    { new Guid("ab298857-93b2-4822-b349-08c03403e035"), "Description of Product 549", "Product 549", 31.62m },
                    { new Guid("ab71a035-c3fb-4dca-ab81-8a35616b3d08"), "Description of Product 130", "Product 130", 6.73m },
                    { new Guid("ac4580b7-0a45-4f70-920e-9e6f5d726c76"), "Description of Product 958", "Product 958", 97.88m },
                    { new Guid("ac7dd4bf-6143-4bb1-a094-774a0fa5303d"), "Description of Product 105", "Product 105", 76.22m },
                    { new Guid("acb0de8b-b4db-4ae2-bdb4-83b16a952918"), "Description of Product 649", "Product 649", 62.51m },
                    { new Guid("acd952c7-d421-475d-844e-3d1dc2098d61"), "Description of Product 665", "Product 665", 31.72m },
                    { new Guid("acf110c6-4b99-4b20-818e-96353d930dbe"), "Description of Product 364", "Product 364", 26.09m },
                    { new Guid("ae5efacb-e2ce-457e-873b-4f57415db12f"), "Description of Product 68", "Product 68", 82.01m },
                    { new Guid("ae74c9e0-80ec-489e-be9e-b0ff09e6628e"), "Description of Product 680", "Product 680", 63.63m },
                    { new Guid("aec5d461-87ac-4df8-8927-3ec965f12066"), "Description of Product 133", "Product 133", 42.46m },
                    { new Guid("afb47d0d-38eb-41eb-bc43-1f3f53513e1f"), "Description of Product 585", "Product 585", 37.28m },
                    { new Guid("afbf2d18-aa7f-4733-9287-7d5765d88f1f"), "Description of Product 444", "Product 444", 78.38m },
                    { new Guid("afc57245-1e7b-4ddd-87a7-196b5b836c1e"), "Description of Product 242", "Product 242", 77.08m },
                    { new Guid("afdf06be-24aa-46a6-8a15-a408990cd12b"), "Description of Product 135", "Product 135", 11.72m },
                    { new Guid("b05b52a0-6483-4ad7-b9f7-b6875c1b5128"), "Description of Product 704", "Product 704", 25.19m },
                    { new Guid("b06be099-48da-4ce1-8197-c0c97b798f11"), "Description of Product 962", "Product 962", 83.62m },
                    { new Guid("b06ebbb7-1aec-47fb-8095-0c9ba676cded"), "Description of Product 392", "Product 392", 57.66m },
                    { new Guid("b0b917be-019b-4684-83be-001de1ce7895"), "Description of Product 163", "Product 163", 92.72m },
                    { new Guid("b12e2b2d-83a6-4176-af72-9c2b39a2f94e"), "Description of Product 606", "Product 606", 44.02m },
                    { new Guid("b13da954-0322-40f1-afc3-44227f64a287"), "Description of Product 639", "Product 639", 96.67m },
                    { new Guid("b18432da-b13b-4acb-ad51-bdbb38d182d6"), "Description of Product 18", "Product 18", 78.43m },
                    { new Guid("b21c0b30-ebc2-4000-bf2d-c8407139d087"), "Description of Product 706", "Product 706", 10.85m },
                    { new Guid("b2cb2301-813c-41f6-a6d1-d3578c2204cc"), "Description of Product 923", "Product 923", 98.04m },
                    { new Guid("b2d202c7-e0a0-4628-b07f-dffe43f05483"), "Description of Product 993", "Product 993", 88.07m },
                    { new Guid("b2ed0f04-7cbd-4891-9da4-2edba246a1a7"), "Description of Product 258", "Product 258", 30.16m },
                    { new Guid("b3404043-1188-4485-872c-a177cbb8a944"), "Description of Product 953", "Product 953", 93.64m },
                    { new Guid("b37395d5-8f51-4d87-8462-a46a9c5befd7"), "Description of Product 563", "Product 563", 20.26m },
                    { new Guid("b37cc56f-6751-42d5-b2f6-de08e5f15b5a"), "Description of Product 411", "Product 411", 29.57m },
                    { new Guid("b41969c3-f5b8-4067-b961-ab61b4958d9b"), "Description of Product 646", "Product 646", 36.09m },
                    { new Guid("b43fece2-00c5-49bc-83e2-b5e96ff124eb"), "Description of Product 568", "Product 568", 46.11m },
                    { new Guid("b475e13b-8d03-4f54-9867-03352d49cee7"), "Description of Product 19", "Product 19", 5.63m },
                    { new Guid("b492d5f9-3fbd-46d4-93e7-f108e88de1cb"), "Description of Product 489", "Product 489", 18.94m },
                    { new Guid("b4a99bca-b5d0-432b-99e5-52f600726b2c"), "Description of Product 349", "Product 349", 31.67m },
                    { new Guid("b50eb6bc-d0b0-4fa1-9d31-b4c88a260f3a"), "Description of Product 834", "Product 834", 26.02m },
                    { new Guid("b5211b3b-4282-43d4-8209-98126d42e76a"), "Description of Product 281", "Product 281", 3.62m },
                    { new Guid("b526a2c8-85b3-438d-8a15-606b28e08300"), "Description of Product 904", "Product 904", 57.13m },
                    { new Guid("b548141b-0823-4688-bb34-9ead0f130e62"), "Description of Product 185", "Product 185", 1.28m },
                    { new Guid("b56e540a-a6eb-4022-ac29-23f07552b710"), "Description of Product 463", "Product 463", 67.43m },
                    { new Guid("b57ff734-00f2-449f-87f3-f8357abeb8c3"), "Description of Product 57", "Product 57", 58.03m },
                    { new Guid("b58ffa5d-ad9f-4215-819d-b0dd03860143"), "Description of Product 272", "Product 272", 80.66m },
                    { new Guid("b599d758-24a7-49ef-b1df-8d98dc64c881"), "Description of Product 454", "Product 454", 2.70m },
                    { new Guid("b6b6eea9-5036-485c-beb4-8e783af7b473"), "Description of Product 191", "Product 191", 67.81m },
                    { new Guid("b6bf7b38-9b82-442b-ba56-9a6d4815fccb"), "Description of Product 235", "Product 235", 70.87m },
                    { new Guid("b73aecf7-0599-4ba6-8132-398e97f5a27b"), "Description of Product 223", "Product 223", 35.42m },
                    { new Guid("b773ba0f-8bfe-4c61-ae6e-56eaf1351eb6"), "Description of Product 676", "Product 676", 73.44m },
                    { new Guid("b797c58d-3a65-4060-8621-5ec075cbed39"), "Description of Product 305", "Product 305", 78.01m },
                    { new Guid("b82f3c96-7b02-426b-85b1-2d75401472ec"), "Description of Product 212", "Product 212", 98.26m },
                    { new Guid("b89fd72e-9f5c-40e2-8a9e-c675faaa41e5"), "Description of Product 575", "Product 575", 48.06m },
                    { new Guid("b8dd92e3-fb2d-4d11-be35-ad0c22559fdf"), "Description of Product 245", "Product 245", 50.56m },
                    { new Guid("b91f6c75-5a29-45c9-bbcc-2d3dec4e1a1b"), "Description of Product 848", "Product 848", 52.27m },
                    { new Guid("b940051e-e2dc-4e32-b9f7-1f9b439e46a3"), "Description of Product 116", "Product 116", 21.16m },
                    { new Guid("b954b7cc-4067-4e9b-8caf-206d1f833553"), "Description of Product 983", "Product 983", 28.14m },
                    { new Guid("b97d131b-8d89-4a9c-993a-1fcc060155ed"), "Description of Product 717", "Product 717", 75.26m },
                    { new Guid("b9e6df17-67ae-4844-83a3-badb845e0fc5"), "Description of Product 127", "Product 127", 20.56m },
                    { new Guid("ba9efebb-5931-4584-8e5c-8c18ed805288"), "Description of Product 484", "Product 484", 52.73m },
                    { new Guid("bacd96a2-c9a4-4f5c-ac8c-b8149deacd53"), "Description of Product 805", "Product 805", 6.07m },
                    { new Guid("bae70b86-786a-4728-a5aa-a0c2f07bde54"), "Description of Product 21", "Product 21", 8.27m },
                    { new Guid("bb357f27-2632-43dd-9f0b-b946b7eca557"), "Description of Product 607", "Product 607", 16.00m },
                    { new Guid("bb6f8f78-4d32-4635-ae63-80e0d46bff60"), "Description of Product 52", "Product 52", 89.70m },
                    { new Guid("bb91f776-8bd1-41e7-ab6d-63c54cc6162c"), "Description of Product 733", "Product 733", 1.10m },
                    { new Guid("bbbe88ec-aa73-4dea-a4b9-5037ad53726c"), "Description of Product 891", "Product 891", 92.42m },
                    { new Guid("bc141fe0-2e8f-4ef2-a671-454a76576ef8"), "Description of Product 595", "Product 595", 2.75m },
                    { new Guid("bc1c90bd-7ff7-4a82-9a8a-fc5f68703d68"), "Description of Product 616", "Product 616", 80.65m },
                    { new Guid("bc56c3f7-c2d8-40f0-9867-048d9496162e"), "Description of Product 329", "Product 329", 55.78m },
                    { new Guid("bc9d8d2c-4c88-4588-90e6-ef7ce7ce155a"), "Description of Product 323", "Product 323", 31.71m },
                    { new Guid("bcd58202-64ab-46b6-8063-29e8edfb7d79"), "Description of Product 835", "Product 835", 47.16m },
                    { new Guid("bcf78a30-f2c9-4d85-b803-c5213cf07434"), "Description of Product 468", "Product 468", 27.08m },
                    { new Guid("bd9e7115-1cb4-4f61-83f8-cc282d62a303"), "Description of Product 317", "Product 317", 41.15m },
                    { new Guid("bdabc74b-afe9-4c90-a46b-5c1e72d209a3"), "Description of Product 529", "Product 529", 25.17m },
                    { new Guid("bdb5ceed-67bb-4f7b-bc6b-05110c17f4a0"), "Description of Product 8", "Product 8", 29.02m },
                    { new Guid("bdcfc530-90b7-4e1c-9967-be57e81b7b2f"), "Description of Product 579", "Product 579", 2.29m },
                    { new Guid("bdd9d1d7-1f7e-4e07-8367-101ca8801eb4"), "Description of Product 927", "Product 927", 45.71m },
                    { new Guid("be4c4792-86f7-4107-aa1d-0d46c32c5199"), "Description of Product 72", "Product 72", 48.44m },
                    { new Guid("be9857a4-8ff8-4428-8d53-1c5a808fabd3"), "Description of Product 496", "Product 496", 67.42m },
                    { new Guid("beef1bf2-ade5-4564-865e-c668f7538332"), "Description of Product 538", "Product 538", 78.17m },
                    { new Guid("bf09b3f7-93d9-4682-b01e-1b65d37a5fe1"), "Description of Product 602", "Product 602", 59.39m },
                    { new Guid("bf4cf67f-b38a-4c23-95fa-4a9e5568d42d"), "Description of Product 482", "Product 482", 46.73m },
                    { new Guid("bf74e759-e2f5-4e71-b665-351d8d211b0c"), "Description of Product 466", "Product 466", 45.58m },
                    { new Guid("bf8f9f1d-f095-4fc5-9faa-936f2f9c8e92"), "Description of Product 813", "Product 813", 53.42m },
                    { new Guid("bfab3f5f-4082-4008-bf96-f1c52a59e2f4"), "Description of Product 307", "Product 307", 62.79m },
                    { new Guid("bfb55512-e8ec-4a30-b445-8f33a7e57068"), "Description of Product 641", "Product 641", 38.55m },
                    { new Guid("c00e1d0d-506b-4a46-b1bf-baab20e3841f"), "Description of Product 960", "Product 960", 96.78m },
                    { new Guid("c02721b3-a1c4-41b0-b8c1-3b9dcd1ca274"), "Description of Product 177", "Product 177", 83.54m },
                    { new Guid("c03b213c-9b3a-4372-b08d-e8310134942a"), "Description of Product 828", "Product 828", 96.24m },
                    { new Guid("c07839d0-7280-4fb7-84fc-095dd2f16b01"), "Description of Product 381", "Product 381", 18.93m },
                    { new Guid("c0b7279f-a0ba-4279-b1d4-8f0136ff9b7e"), "Description of Product 26", "Product 26", 22.00m },
                    { new Guid("c0df9fd6-3757-4b88-963c-50dca81f8ee4"), "Description of Product 89", "Product 89", 93.81m },
                    { new Guid("c1841766-1afa-4054-8cb9-c46e18847813"), "Description of Product 711", "Product 711", 9.57m },
                    { new Guid("c18e30c0-8c0b-4cee-96d6-25c731867c75"), "Description of Product 697", "Product 697", 10.26m },
                    { new Guid("c1ab6b60-57e2-427d-a0b9-7a6ad40fe9e2"), "Description of Product 276", "Product 276", 2.18m },
                    { new Guid("c1ae7f0f-844e-43e7-9400-da4ae0b7da29"), "Description of Product 622", "Product 622", 27.62m },
                    { new Guid("c22f8006-febd-4e46-a903-75d3f86334e3"), "Description of Product 296", "Product 296", 77.19m },
                    { new Guid("c24237f4-db51-4693-8bcf-30075ce83495"), "Description of Product 25", "Product 25", 91.18m },
                    { new Guid("c2e68861-d9b9-4006-a5c3-9c4529dd39e1"), "Description of Product 990", "Product 990", 66.05m },
                    { new Guid("c332d8fe-61da-46a5-85b2-c9569379e1a4"), "Description of Product 692", "Product 692", 45.41m },
                    { new Guid("c3397b90-5686-42b0-9ed1-9312295cf708"), "Description of Product 453", "Product 453", 2.82m },
                    { new Guid("c3ef6574-5002-4c04-a472-425af1fd67b2"), "Description of Product 791", "Product 791", 56.52m },
                    { new Guid("c4560f23-e43b-42a4-93a0-b918b04b4faf"), "Description of Product 356", "Product 356", 1.47m },
                    { new Guid("c4d61c39-2590-4e1b-b78c-a510fcdb51cc"), "Description of Product 693", "Product 693", 89.90m },
                    { new Guid("c5522c6e-3c82-4da6-98f4-c6cac45829c0"), "Description of Product 240", "Product 240", 12.55m },
                    { new Guid("c5685730-eed6-45cf-a935-4cdff1f78acc"), "Description of Product 621", "Product 621", 75.62m },
                    { new Guid("c59da5f0-5ffe-4809-b577-8e3d483be239"), "Description of Product 206", "Product 206", 93.01m },
                    { new Guid("c5c05dc0-79a2-4757-8039-e6a7dcf5a1b6"), "Description of Product 294", "Product 294", 95.39m },
                    { new Guid("c60abb8b-a9af-4163-84eb-2c3934cda79d"), "Description of Product 184", "Product 184", 40.71m },
                    { new Guid("c63dc555-756b-4e03-8c89-9b1324759871"), "Description of Product 425", "Product 425", 86.19m },
                    { new Guid("c64642f0-7c21-4e48-8b77-8ebc007e51c6"), "Description of Product 876", "Product 876", 8.06m },
                    { new Guid("c68df755-ef10-429c-b048-cbd9bc0273de"), "Description of Product 82", "Product 82", 8.37m },
                    { new Guid("c6c75178-6da1-4f89-bbbc-5ea8d0c5c61f"), "Description of Product 922", "Product 922", 22.25m },
                    { new Guid("c738f466-7450-4489-b033-744f0c3d8d3b"), "Description of Product 783", "Product 783", 36.56m },
                    { new Guid("c763d33a-05b8-43c3-9621-5711c6ddd20f"), "Description of Product 39", "Product 39", 2.60m },
                    { new Guid("c7a20d1f-60c9-430f-b918-14c5192a5dcc"), "Description of Product 588", "Product 588", 45.49m },
                    { new Guid("c7e3b0f1-484f-469c-a020-f498726ecb91"), "Description of Product 582", "Product 582", 34.26m },
                    { new Guid("c7f24c15-35f5-4246-a778-6c81c802d9bc"), "Description of Product 217", "Product 217", 14.50m },
                    { new Guid("c8305ceb-5404-4f43-8189-a324f2d074c1"), "Description of Product 409", "Product 409", 87.40m },
                    { new Guid("c83796de-0400-4d06-8410-ecdb83981c09"), "Description of Product 388", "Product 388", 94.06m },
                    { new Guid("c83b4b32-5157-4e9d-9524-fd2ae4ce2b09"), "Description of Product 982", "Product 982", 23.67m },
                    { new Guid("c841f88c-aa3b-4935-8aec-5120925b4f4e"), "Description of Product 50", "Product 50", 67.46m },
                    { new Guid("c84cf139-d2c0-4262-8ace-4fa58d9855c4"), "Description of Product 76", "Product 76", 87.38m },
                    { new Guid("c8f86d1b-ac99-406b-a79e-f2af427881c0"), "Description of Product 226", "Product 226", 98.64m },
                    { new Guid("c9635ef2-1498-4cfe-a105-d07318749c02"), "Description of Product 55", "Product 55", 12.74m },
                    { new Guid("c99e4a3c-27f2-4485-8682-84cca17f2981"), "Description of Product 788", "Product 788", 36.85m },
                    { new Guid("ca2e8a99-067a-4532-afbd-eba5a85bf2a0"), "Description of Product 806", "Product 806", 5.84m },
                    { new Guid("caddfd92-d138-4202-8036-24f672b65b69"), "Description of Product 161", "Product 161", 6.40m },
                    { new Guid("cb20b069-37a2-4373-9f88-8db9adcb405d"), "Description of Product 346", "Product 346", 45.63m },
                    { new Guid("cb339de6-688e-48b2-bb54-63e5e10ae0be"), "Description of Product 268", "Product 268", 11.20m },
                    { new Guid("cb603075-f5bb-414a-b299-a8c14eaa5180"), "Description of Product 907", "Product 907", 13.06m },
                    { new Guid("cb88cba5-42d2-4488-ad74-0599a86ff2fb"), "Description of Product 742", "Product 742", 82.87m },
                    { new Guid("cb9a6a17-a3ff-4b30-ab03-ba0a0377104a"), "Description of Product 894", "Product 894", 15.72m },
                    { new Guid("cbe7daae-07d4-4f76-83f6-40c0fb58c950"), "Description of Product 912", "Product 912", 69.83m },
                    { new Guid("cc49f360-5a86-467b-9e64-541abd8d3b99"), "Description of Product 13", "Product 13", 22.79m },
                    { new Guid("cc92825f-b360-4b27-a5fd-50d9d93b6158"), "Description of Product 895", "Product 895", 95.81m },
                    { new Guid("cca6917e-3b29-4e33-94c3-14ed35f961a7"), "Description of Product 868", "Product 868", 2.43m },
                    { new Guid("cce9c356-473e-4d5d-b95b-487f90ae4580"), "Description of Product 67", "Product 67", 9.92m },
                    { new Guid("cd82c750-d992-474f-9dee-a3c06f99c85d"), "Description of Product 633", "Product 633", 57.26m },
                    { new Guid("cd8af7d2-9519-4913-8efd-42c4c3b0dc5f"), "Description of Product 209", "Product 209", 1.52m },
                    { new Guid("cddbae2d-91f0-4185-aad2-c968ab9d131c"), "Description of Product 917", "Product 917", 25.61m },
                    { new Guid("ce1b20b6-d116-40fe-a31f-470cd225c995"), "Description of Product 645", "Product 645", 64.59m },
                    { new Guid("ce6036d6-510f-47e8-8bf4-255bfc7a99d2"), "Description of Product 304", "Product 304", 10.70m },
                    { new Guid("cf13ced2-27cf-474c-a764-55acd978ee6d"), "Description of Product 504", "Product 504", 16.46m },
                    { new Guid("cf266084-fb11-46da-8099-e9977798a4df"), "Description of Product 132", "Product 132", 80.76m },
                    { new Guid("cfa82c74-9e9d-43c9-855a-90f5db0df3cb"), "Description of Product 586", "Product 586", 8.93m },
                    { new Guid("cfb21d61-40b9-4358-8bb2-f743367eede4"), "Description of Product 926", "Product 926", 17.61m },
                    { new Guid("d00908f0-d0be-4cd3-885b-7cac0dafe5e4"), "Description of Product 167", "Product 167", 18.69m },
                    { new Guid("d027493a-428f-407d-b275-03780462dafd"), "Description of Product 629", "Product 629", 23.01m },
                    { new Guid("d0e16f5c-3ca3-4327-b96e-173c69f17a3c"), "Description of Product 562", "Product 562", 51.32m },
                    { new Guid("d102c8ac-fe22-47e7-b47e-1e51cabcca76"), "Description of Product 714", "Product 714", 30.16m },
                    { new Guid("d115fad4-643e-4962-b2d9-715734ec1b47"), "Description of Product 976", "Product 976", 40.53m },
                    { new Guid("d132052a-264d-4643-84a3-dc31666710de"), "Description of Product 472", "Product 472", 97.37m },
                    { new Guid("d13c8be4-e320-4496-8473-293e9276af5f"), "Description of Product 443", "Product 443", 42.37m },
                    { new Guid("d13c9826-c6e8-4c14-863b-5e2ca6ae821c"), "Description of Product 853", "Product 853", 8.45m },
                    { new Guid("d23aae7d-81ad-4d48-b086-813201fffb8f"), "Description of Product 724", "Product 724", 58.30m },
                    { new Guid("d25f544a-70ed-4f04-80b3-4c2ba1cdce72"), "Description of Product 587", "Product 587", 71.52m },
                    { new Guid("d28f7696-8553-45f1-9550-38db218a8f59"), "Description of Product 44", "Product 44", 64.14m },
                    { new Guid("d3a5e21a-4a41-480b-8c87-3e35b5cfcf07"), "Description of Product 102", "Product 102", 24.94m },
                    { new Guid("d3cd727a-ba1f-40fd-8f0a-293466624752"), "Description of Product 224", "Product 224", 11.64m },
                    { new Guid("d3d48b47-ba5b-4983-99f0-6ff4f855ab27"), "Description of Product 377", "Product 377", 71.31m },
                    { new Guid("d4169217-6912-4979-ae21-293a39f494ff"), "Description of Product 220", "Product 220", 2.70m },
                    { new Guid("d508ac28-84de-47e6-8806-591c44c78331"), "Description of Product 882", "Product 882", 63.10m },
                    { new Guid("d5a08be0-8740-45c3-8eb6-072c6edbf4ac"), "Description of Product 556", "Product 556", 25.20m },
                    { new Guid("d6060c64-29b6-4a9b-802e-6fc872ce52e9"), "Description of Product 53", "Product 53", 23.09m },
                    { new Guid("d6144dbe-483d-498f-9e93-b2592fe113b2"), "Description of Product 412", "Product 412", 81.14m },
                    { new Guid("d6462e89-29d5-417d-8a28-7fb3a1da4683"), "Description of Product 75", "Product 75", 88.56m },
                    { new Guid("d67334c0-f775-4a7e-86f8-6a22fbb81305"), "Description of Product 436", "Product 436", 62.39m },
                    { new Guid("d6bdfeb3-3d4e-4a82-818a-0a81220c7738"), "Description of Product 336", "Product 336", 15.26m },
                    { new Guid("d71f5d09-67fb-4b13-af8c-fcae3e33c757"), "Description of Product 345", "Product 345", 69.39m },
                    { new Guid("d74ed632-e803-47ea-9ee7-357c56bd8b2c"), "Description of Product 517", "Product 517", 48.38m },
                    { new Guid("d78f0667-7309-48d7-8bb4-bf7d6df91d2b"), "Description of Product 514", "Product 514", 60.06m },
                    { new Guid("d7d1c62e-f138-428a-bda4-4af1b7300348"), "Description of Product 919", "Product 919", 6.94m },
                    { new Guid("d806482c-60fb-4a2c-9a74-729694334243"), "Description of Product 903", "Product 903", 78.47m },
                    { new Guid("d82a8cfe-9c41-4fd5-bd9d-ca68732b6fa8"), "Description of Product 45", "Product 45", 58.58m },
                    { new Guid("d86aeb2f-505c-43f2-9354-a47f58713c86"), "Description of Product 149", "Product 149", 1.17m },
                    { new Guid("d8d3530c-7a16-452e-93ef-3c35d9474a31"), "Description of Product 202", "Product 202", 11.08m },
                    { new Guid("d929aa1e-30c2-482d-a494-27b0b05f3408"), "Description of Product 100", "Product 100", 33.20m },
                    { new Guid("d92e6bcf-f5ba-4bd1-a0a2-cacb9070717c"), "Description of Product 992", "Product 992", 70.63m },
                    { new Guid("d9417dcc-6555-4eba-b371-12a404d83f51"), "Description of Product 559", "Product 559", 75.69m },
                    { new Guid("d9811373-4dbd-4511-a288-6b9fa8496650"), "Description of Product 239", "Product 239", 70.45m },
                    { new Guid("d988d56f-f708-4f6c-846f-535a2f8b2d39"), "Description of Product 383", "Product 383", 84.62m },
                    { new Guid("d9de8031-1fde-4b3f-96dd-5415202097f9"), "Description of Product 434", "Product 434", 52.73m },
                    { new Guid("d9e7dfbf-ce8d-43d8-aec7-2a265bb8e5b1"), "Description of Product 531", "Product 531", 85.66m },
                    { new Guid("dac0e757-f35b-473c-b049-51fe21126bbd"), "Description of Product 655", "Product 655", 79.88m },
                    { new Guid("db0c8125-d6f0-475c-8782-489641493413"), "Description of Product 780", "Product 780", 78.50m },
                    { new Guid("db6d6a3a-0aaf-4af8-bc1a-48112885be12"), "Description of Product 248", "Product 248", 85.72m },
                    { new Guid("dbd5531b-1ab0-40de-bd18-612b6fe8b626"), "Description of Product 88", "Product 88", 84.37m },
                    { new Guid("dc38e31e-4ca2-4294-b9d5-f26a4aa31d8a"), "Description of Product 721", "Product 721", 18.65m },
                    { new Guid("dc3b6e94-d47c-4c1e-bd12-823865b5afce"), "Description of Product 546", "Product 546", 8.89m },
                    { new Guid("dcaabe1e-2b0c-4cc5-a084-3e96a9fb31d6"), "Description of Product 913", "Product 913", 75.65m },
                    { new Guid("dcbeb8f8-89eb-4c5f-9327-0c551bbf451f"), "Description of Product 290", "Product 290", 70.04m },
                    { new Guid("dcf28385-342d-4658-a0a2-ee6edee46da0"), "Description of Product 194", "Product 194", 93.67m },
                    { new Guid("dd3cbd93-6aac-4221-be30-a5b6fe3f2fd5"), "Description of Product 941", "Product 941", 17.99m },
                    { new Guid("dd6cfccd-ff4c-4e42-b8b9-941a17899a00"), "Description of Product 972", "Product 972", 39.79m },
                    { new Guid("dd7b6d6a-8a22-4de0-9084-4cecae9c8d6b"), "Description of Product 825", "Product 825", 98.75m },
                    { new Guid("dd882570-869d-4fe9-9eb5-1c316c49133b"), "Description of Product 661", "Product 661", 43.05m },
                    { new Guid("de075d74-f7a3-4896-b90f-89c407b82c2e"), "Description of Product 799", "Product 799", 23.39m },
                    { new Guid("dedb5b35-4d84-48d0-920a-b5dcbcab5885"), "Description of Product 716", "Product 716", 1.31m },
                    { new Guid("df204655-c201-429a-9b16-e01f6a72eb60"), "Description of Product 164", "Product 164", 65.23m },
                    { new Guid("df315afc-c570-4cc7-9fdb-060d2b99c90d"), "Description of Product 816", "Product 816", 97.43m },
                    { new Guid("df3aaf62-ebdf-49ba-a729-d0252c42187e"), "Description of Product 123", "Product 123", 46.77m },
                    { new Guid("dfce11c9-9adc-46c6-9fe4-f810d6c805d6"), "Description of Product 126", "Product 126", 72.03m },
                    { new Guid("dfd86d42-9ee2-4477-80b4-8e7fad3680b2"), "Description of Product 591", "Product 591", 79.07m },
                    { new Guid("e06f7678-b589-4203-8e96-9afa6e27a95e"), "Description of Product 348", "Product 348", 25.03m },
                    { new Guid("e0cb0435-878d-41f6-b311-42f78ae685b8"), "Description of Product 552", "Product 552", 90.84m },
                    { new Guid("e104a645-2d97-434a-ac83-6fa73b6da4ff"), "Description of Product 140", "Product 140", 73.85m },
                    { new Guid("e17c9886-8cc1-42dc-a050-d4897ed29144"), "Description of Product 87", "Product 87", 69.64m },
                    { new Guid("e19934a9-aec0-4418-9ba2-b9b4268894fe"), "Description of Product 324", "Product 324", 15.69m },
                    { new Guid("e1d3a621-c47f-43ce-9dc3-56fefe6e0b7e"), "Description of Product 673", "Product 673", 32.31m },
                    { new Guid("e27c5b9f-3490-4bd8-9f83-a989f49af5e0"), "Description of Product 328", "Product 328", 93.77m },
                    { new Guid("e2d0af86-7be9-4493-90b9-d66240b3157b"), "Description of Product 652", "Product 652", 3.76m },
                    { new Guid("e2e5ee3a-8ab9-4973-b684-32b27e1dac30"), "Description of Product 509", "Product 509", 95.65m },
                    { new Guid("e307e764-b2a1-4ba5-b41c-6c0a9702e635"), "Description of Product 274", "Product 274", 21.85m },
                    { new Guid("e31fc6ee-3987-4c16-8079-c94302454980"), "Description of Product 48", "Product 48", 45.21m },
                    { new Guid("e32c034e-7091-4e52-a7ce-d389a6f16118"), "Description of Product 725", "Product 725", 29.77m },
                    { new Guid("e36d0a60-58f2-493f-aeed-59ec3ca39de5"), "Description of Product 181", "Product 181", 82.33m },
                    { new Guid("e3bc0989-a4b9-4977-870d-10839c2fd476"), "Description of Product 40", "Product 40", 15.21m },
                    { new Guid("e3c5a8fa-0f36-48c8-82ea-448497d45ec1"), "Description of Product 677", "Product 677", 30.32m },
                    { new Guid("e3e7d992-2019-4b50-8a36-86ee61ad9c0b"), "Description of Product 61", "Product 61", 69.77m },
                    { new Guid("e4049709-0ba9-4ef3-b6b2-c5dcef62606f"), "Description of Product 437", "Product 437", 79.50m },
                    { new Guid("e47f4100-cfb6-48b7-a851-facfd8b423a7"), "Description of Product 850", "Product 850", 31.96m },
                    { new Guid("e495afe2-e0b4-4338-8cd1-fcd0a7bbcadd"), "Description of Product 787", "Product 787", 21.00m },
                    { new Guid("e4b880a4-5fe2-4576-9052-a7d6ed80c4d0"), "Description of Product 609", "Product 609", 62.46m },
                    { new Guid("e4f0255b-3ad3-40b6-a4dc-f622717907c1"), "Description of Product 984", "Product 984", 53.20m },
                    { new Guid("e54a7ff5-2164-4eb6-8414-62b09fe557f7"), "Description of Product 320", "Product 320", 21.78m },
                    { new Guid("e576f796-67e6-49e2-aed1-f6df46f0de89"), "Description of Product 564", "Product 564", 3.05m },
                    { new Guid("e5820cbe-b9ba-412d-ab57-d9a6c6ad3ab9"), "Description of Product 843", "Product 843", 37.68m },
                    { new Guid("e5d9a6ef-e6e6-49ac-9a8a-537360f54e18"), "Description of Product 985", "Product 985", 84.64m },
                    { new Guid("e61f9450-0843-4525-a0f0-29208111e8d1"), "Description of Product 701", "Product 701", 11.28m },
                    { new Guid("e62eb2ab-3b60-46db-826f-3a0e58d8f27d"), "Description of Product 659", "Product 659", 5.65m },
                    { new Guid("e63f303a-56bc-44b9-98d2-b9b96fd2cbf5"), "Description of Product 112", "Product 112", 37.93m },
                    { new Guid("e704e897-e75e-4de5-b397-bd8a6e4bb0d9"), "Description of Product 97", "Product 97", 7.12m },
                    { new Guid("e73d5f63-2662-4408-956d-b4f808930712"), "Description of Product 765", "Product 765", 91.60m },
                    { new Guid("e7880329-5596-46d5-aa58-34023cb3a894"), "Description of Product 640", "Product 640", 32.70m },
                    { new Guid("e79f6673-fed9-486e-b18a-e52ae6c438c0"), "Description of Product 125", "Product 125", 45.01m },
                    { new Guid("e8356f03-168c-431a-9817-65ab79b0b3b2"), "Description of Product 610", "Product 610", 61.00m },
                    { new Guid("e843d65b-286e-4001-b288-34c8068375f5"), "Description of Product 911", "Product 911", 48.52m },
                    { new Guid("e8508bd7-44bd-4451-a1d0-104fafe4e532"), "Description of Product 442", "Product 442", 83.28m },
                    { new Guid("e87755c1-bd62-4cda-a6a5-58155f6b48a4"), "Description of Product 731", "Product 731", 13.37m },
                    { new Guid("e89d5cc7-f52d-496d-9229-0c995d093800"), "Description of Product 176", "Product 176", 95.59m },
                    { new Guid("e8b5842f-7711-4a96-a537-003e7c1cee1f"), "Description of Product 662", "Product 662", 95.03m },
                    { new Guid("e8f266a9-39c8-46f5-bf5f-a381d565347d"), "Description of Product 374", "Product 374", 28.72m },
                    { new Guid("e9421813-ac31-4ef8-a732-e12eae0ef90e"), "Description of Product 635", "Product 635", 48.04m },
                    { new Guid("e97238fc-261a-4b9b-85a0-8b0425ec0e1b"), "Description of Product 756", "Product 756", 42.94m },
                    { new Guid("e9883c02-661c-421d-9654-2be3e87f1989"), "Description of Product 961", "Product 961", 1.48m },
                    { new Guid("e9cddea4-33cf-4999-b960-84a859385991"), "Description of Product 738", "Product 738", 43.01m },
                    { new Guid("ea4872c4-d780-4795-8b43-e84e4499c1f2"), "Description of Product 200", "Product 200", 2.14m },
                    { new Guid("ea4b0c7e-df04-413f-b9b0-c30eb5cbfc3b"), "Description of Product 910", "Product 910", 40.23m },
                    { new Guid("ea5ac026-0393-4a3b-a338-998de9871dfe"), "Description of Product 119", "Product 119", 73.50m },
                    { new Guid("ea70f751-cb62-48b6-b020-f35d77d3df27"), "Description of Product 156", "Product 156", 79.54m },
                    { new Guid("ebe909b8-4d7a-45de-9bfb-c4520732c6e0"), "Description of Product 389", "Product 389", 49.79m },
                    { new Guid("ec181af9-dd29-44c9-b086-de1bf97bc435"), "Description of Product 139", "Product 139", 12.53m },
                    { new Guid("ec747907-1e68-4b20-a577-c0cc1199500d"), "Description of Product 571", "Product 571", 99.82m },
                    { new Guid("ec8d67a5-8adc-4d35-b8d6-00fef7635a90"), "Description of Product 774", "Product 774", 25.55m },
                    { new Guid("eca81bed-dbce-48e8-ad3c-79c1a41e7833"), "Description of Product 387", "Product 387", 91.27m },
                    { new Guid("ece0c277-2a70-4f61-bef4-1111c351cef8"), "Description of Product 928", "Product 928", 69.94m },
                    { new Guid("ed337da3-1204-4408-8378-2e96cb1da940"), "Description of Product 929", "Product 929", 38.58m },
                    { new Guid("ed784d4c-a0f4-48eb-952f-8baf0abd9c7a"), "Description of Product 743", "Product 743", 58.60m },
                    { new Guid("ee6df4d6-e93f-48e8-8a79-5fbe9a65c34e"), "Description of Product 120", "Product 120", 4.62m },
                    { new Guid("eec78767-59bc-4e0b-962a-f54de5252755"), "Description of Product 744", "Product 744", 5.85m },
                    { new Guid("eed9c050-cac6-42c2-b525-8da81924fe0f"), "Description of Product 573", "Product 573", 3.51m },
                    { new Guid("eeec961e-7ab6-443e-81e5-470a91a211f3"), "Description of Product 651", "Product 651", 13.00m },
                    { new Guid("ef0b33de-a321-43b0-8f5c-c198e08556f1"), "Description of Product 174", "Product 174", 47.12m },
                    { new Guid("ef283239-71cb-4dd9-b50a-e49c7874fc9f"), "Description of Product 930", "Product 930", 24.52m },
                    { new Guid("ef62019a-b991-4436-8b6a-98d2d7de27db"), "Description of Product 232", "Product 232", 54.40m },
                    { new Guid("efc1adcc-2c2e-4439-b97f-edbdf983bda2"), "Description of Product 255", "Product 255", 8.45m },
                    { new Guid("f010ba96-a815-4415-b670-cbc2728a0ae3"), "Description of Product 957", "Product 957", 57.60m },
                    { new Guid("f014183e-f963-48e4-9de5-88df0a62a23d"), "Description of Product 720", "Product 720", 18.60m },
                    { new Guid("f06c7885-95f1-4030-879c-3fd220a4053c"), "Description of Product 741", "Product 741", 27.83m },
                    { new Guid("f0ed1805-63c4-4f7d-b25a-1932e36edb2b"), "Description of Product 398", "Product 398", 54.44m },
                    { new Guid("f137fb5f-5e94-4467-b286-9ce3c885a812"), "Description of Product 666", "Product 666", 57.89m },
                    { new Guid("f1769adf-7151-4426-b812-359bcc533750"), "Description of Product 572", "Product 572", 36.86m },
                    { new Guid("f190b293-bbc8-4239-ad78-8ba707db0ac7"), "Description of Product 934", "Product 934", 11.58m },
                    { new Guid("f1a776b6-b264-41ee-a6ec-b54e76da0a8b"), "Description of Product 723", "Product 723", 60.69m },
                    { new Guid("f1e54c8b-aade-4979-abae-170bfde534e3"), "Description of Product 316", "Product 316", 20.73m },
                    { new Guid("f2549175-5cd9-4d0e-8d5b-2d5f1cab3e47"), "Description of Product 378", "Product 378", 15.09m },
                    { new Guid("f2579d04-d534-40df-9f54-17b7dcc89ce9"), "Description of Product 213", "Product 213", 24.85m },
                    { new Guid("f2a195bc-d16e-4b12-9d3d-5e8f074b7e80"), "Description of Product 631", "Product 631", 78.70m },
                    { new Guid("f2b9d5a8-00a6-4976-9cbd-8ef362b8be69"), "Description of Product 728", "Product 728", 74.10m },
                    { new Guid("f2fac153-2aef-4d55-b329-4991008fda1d"), "Description of Product 24", "Product 24", 35.97m },
                    { new Guid("f2fe134f-0eeb-4d96-8ce3-73589a4eee5f"), "Description of Product 236", "Product 236", 19.98m },
                    { new Guid("f32d370b-1a4c-4a25-a841-3d43e1c7d623"), "Description of Product 180", "Product 180", 20.60m },
                    { new Guid("f358abfa-27d1-42ec-951f-64e291dd3e84"), "Description of Product 729", "Product 729", 50.61m },
                    { new Guid("f3772a6a-846e-43aa-9652-4214d931463f"), "Description of Product 210", "Product 210", 60.16m },
                    { new Guid("f399fdae-2183-44b2-86af-4d6bb31bd0a5"), "Description of Product 306", "Product 306", 61.71m },
                    { new Guid("f416aad6-ba1b-46ca-8d8f-cd1bf3538def"), "Description of Product 892", "Product 892", 60.24m },
                    { new Guid("f42914be-76dc-4dbf-ac62-d57d2947bc1b"), "Description of Product 786", "Product 786", 4.56m },
                    { new Guid("f438c888-2933-40cb-9a77-0df59f93bc4b"), "Description of Product 883", "Product 883", 70.00m },
                    { new Guid("f45f1a86-230a-40ba-9823-e68fb43cd07b"), "Description of Product 460", "Product 460", 15.24m },
                    { new Guid("f49ca7bd-f72b-4ccf-960c-75489adddff9"), "Description of Product 415", "Product 415", 78.59m },
                    { new Guid("f551ff28-78de-4eba-9e9e-e60ee86f52ec"), "Description of Product 2", "Product 2", 5.29m },
                    { new Guid("f5a64c91-6d3d-430a-b682-6285de8cccb0"), "Description of Product 969", "Product 969", 38.27m },
                    { new Guid("f5f592be-a93b-4c64-8eb9-a9eea7b60902"), "Description of Product 890", "Product 890", 46.25m },
                    { new Guid("f64d9d3b-56df-4ca3-b3d5-810a240c746c"), "Description of Product 896", "Product 896", 76.50m },
                    { new Guid("f6554208-9e98-489c-88ec-8d89285d8222"), "Description of Product 278", "Product 278", 32.37m },
                    { new Guid("f6c62795-08a9-4779-9790-faa1e5687541"), "Description of Product 897", "Product 897", 75.76m },
                    { new Guid("f6dc3cac-03bc-4714-853d-2abde3d38cf8"), "Description of Product 898", "Product 898", 87.89m },
                    { new Guid("f7275cee-948e-4c3c-a9a9-fcf4f49d63cd"), "Description of Product 686", "Product 686", 69.15m },
                    { new Guid("f738362b-f905-464f-a320-aab402594964"), "Description of Product 627", "Product 627", 90.01m },
                    { new Guid("f7637bcf-92fe-4f57-8e41-517789ec8c43"), "Description of Product 807", "Product 807", 28.74m },
                    { new Guid("f76c5d48-6023-4590-8a0e-dae61ef2e09c"), "Description of Product 331", "Product 331", 28.50m },
                    { new Guid("f7753fd0-abc5-4b93-a402-1a4f3c869ed1"), "Description of Product 204", "Product 204", 60.55m },
                    { new Guid("f7973410-aef3-4229-846b-f6ed87e5cada"), "Description of Product 477", "Product 477", 91.92m },
                    { new Guid("f7f3212b-d277-43d8-993c-f2a4d8a730b7"), "Description of Product 967", "Product 967", 46.24m },
                    { new Guid("f7fad7ca-105f-4c91-a5d1-757a5f88f270"), "Description of Product 576", "Product 576", 85.72m },
                    { new Guid("f8130449-75e1-4a2f-9125-f63e4517f0e2"), "Description of Product 300", "Product 300", 63.85m },
                    { new Guid("f81e90ad-f78b-4b7a-a2c4-c1067f61a9b3"), "Description of Product 490", "Product 490", 11.04m },
                    { new Guid("f89bfc82-8672-4fd5-b01e-f45ed8ce329e"), "Description of Product 186", "Product 186", 69.30m },
                    { new Guid("f8fb8f4c-6046-4c59-aaaa-8ab2db455b2a"), "Description of Product 361", "Product 361", 12.71m },
                    { new Guid("f940b00d-f384-4bda-b396-5e2f9d849b8a"), "Description of Product 134", "Product 134", 24.01m },
                    { new Guid("f94f681e-e282-490a-ba84-853be009d826"), "Description of Product 28", "Product 28", 21.51m },
                    { new Guid("f990b05c-ac0c-4e60-b43b-231b2c9af99c"), "Description of Product 636", "Product 636", 85.35m },
                    { new Guid("fa3be739-9812-434c-97d5-9556c0c624a8"), "Description of Product 312", "Product 312", 96.98m },
                    { new Guid("fad54e3e-7715-445f-ae16-e80157258a62"), "Description of Product 253", "Product 253", 65.80m },
                    { new Guid("fb8ee40b-cdcf-465b-8cf0-a719f47f29eb"), "Description of Product 187", "Product 187", 45.21m },
                    { new Guid("fbb08b1c-ff7e-480a-b74a-5c21a472e73a"), "Description of Product 578", "Product 578", 44.08m },
                    { new Guid("fbd3a0f6-1351-41bc-a0b8-b516207599bb"), "Description of Product 981", "Product 981", 99.11m },
                    { new Guid("fbd81b35-0516-407b-8424-72b3719a7950"), "Description of Product 91", "Product 91", 29.24m },
                    { new Guid("fbde8456-6ee4-41cf-b889-01b4cbf0e9e3"), "Description of Product 925", "Product 925", 88.83m },
                    { new Guid("fc733fad-94e1-4e94-9da4-05f8b7aab4b1"), "Description of Product 470", "Product 470", 73.91m },
                    { new Guid("fcc3e3df-93ab-42c2-90c3-8b7221e5df44"), "Description of Product 712", "Product 712", 39.81m },
                    { new Guid("fd4801bf-d020-4c6b-921d-81b52f46544f"), "Description of Product 170", "Product 170", 9.32m },
                    { new Guid("fd932b99-a5e2-4625-b92e-98c585dc4537"), "Description of Product 99", "Product 99", 16.59m },
                    { new Guid("fdac9aa7-a594-4d85-9fd2-28202218f20a"), "Description of Product 308", "Product 308", 65.66m },
                    { new Guid("fe3502fe-65ff-4743-a668-38ebe5637f00"), "Description of Product 691", "Product 691", 56.12m },
                    { new Guid("fe6e8c43-27a7-4ae0-a533-c288cf5feb91"), "Description of Product 222", "Product 222", 91.98m },
                    { new Guid("fe7adf84-da02-4181-96c8-274f7507275e"), "Description of Product 521", "Product 521", 98.45m },
                    { new Guid("fec5f6f9-1c65-4075-8367-e6cabc9073f6"), "Description of Product 292", "Product 292", 93.77m },
                    { new Guid("feed08e3-bee2-4d95-bd2b-f79f3cb63e2a"), "Description of Product 342", "Product 342", 75.97m },
                    { new Guid("ff01f31f-3e5d-4af1-8e94-c4018712072e"), "Description of Product 118", "Product 118", 47.15m },
                    { new Guid("ff9582b4-9cc4-4384-916d-9b9d84e76e91"), "Description of Product 671", "Product 671", 59.25m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("013bf318-726a-4083-ad0a-d03c66064cdc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0169134c-db53-459b-8fb3-814871a2c020"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("019dab72-a79a-43bc-ad2c-ff8d1674b6c3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("021857f9-2a4c-4e6c-9f0e-5b22662479e9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("02269167-046a-42fd-9f14-2b0ea770514f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("025306c3-90b6-4f3b-9e4a-ee9c5822c566"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0263d706-1486-4f1e-b56d-fc3dfe1c1d63"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("02b087b0-8935-4639-a8b0-b4d37a4f1302"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("02f2c4a6-2867-4421-9e3d-3fc8d34ea0ea"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("032f1514-6f67-41ab-aacd-a500f3f9cf70"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("033be478-fe88-4e6b-87b8-6da9a2b9a687"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("03851548-f039-48fa-803e-5124c47899f3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("03ac1f17-fd0a-4ce1-bd8f-24e52df38854"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("03ace643-9eb9-46e4-9474-6952e632f0c4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("03e11643-5623-4b33-b4e4-4895d1c6ab8d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("049e5b3b-6641-4fd2-8141-3a34b9e06529"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0504d0c3-cb83-4a29-a881-c9b17e8ab80f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0568f7a5-0bf4-4ba7-a2e2-b08865c45e43"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("056f1be9-5683-4173-bbd2-b6270c47198b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("057a375c-69ea-4006-a3a8-871a1447e565"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("059a44aa-9b9e-466e-9a66-627db8634d91"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("05e2a57f-1149-42f6-87bc-dd3f080438f6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("060aa81d-4d74-4488-8a44-e68385c623f0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("062a7e33-43ca-48fc-8889-831c351ed3f2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("06516130-ce8b-482e-b6da-ec2e8e15df17"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("066626d1-010d-4f2e-98dc-436d6d2b9ba6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("069717ce-06bc-4cae-81e4-2b8c2f24f5cf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("06b81ae6-0957-4b96-aca0-c546d6062261"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("06c4e92a-a21c-415d-bcf9-cd0e97765a43"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("06e8676a-d84f-454b-90f2-74bc0bb2b736"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0766b09f-d254-4d4c-a5d3-a47aef064ec2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0770bbe3-25e6-48d9-a182-a49d9ff86ae9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("07bb8783-ef23-41f3-8240-6f910e17f2fc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("07e5455c-2b20-418d-a422-4e003b56b742"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("07e7d5f7-c12e-4c96-860d-e1e7c5e3357c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("07ea2db2-e139-48de-b751-ebbfe4e36c4c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("081ae2a1-942d-4cff-955a-f378c51cf0ef"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("082cc873-4b2b-4c0d-a6b1-2f7986596db9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("08e3c904-d105-427f-8e01-e98efdccdfbf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("09240244-8929-4308-8f6b-909b4a8fdc0b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("097de688-f1b3-435a-8671-80e8c2af1073"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("09b236b2-1a3a-4c88-819a-649e55cc1603"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("09db1394-9604-4b8e-b2ce-9fc5633ad576"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("09ed2e39-e4da-4f8c-8988-e09fbc56503d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0a454e65-352d-465c-8d9e-bf6aea4eba95"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0a6e6c33-77b2-452b-b485-5d2800793821"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0aec3203-0e3c-4510-9f50-192be453a2df"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0b451860-3037-4450-98f7-53e4e2f4624f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0b57741b-765f-4716-b1b3-4944f45ad20a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0b5e947c-5920-43ea-a269-a773b37fdc77"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0bb454fd-f76a-4a80-bd9d-1b3a0f654755"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0ca299c1-6b7a-4ecc-9f1a-92a4c4cd7027"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0d2b4ca8-6d6e-4fed-952a-99efef524b2e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0d368d7d-84e4-4fac-8e81-758d73a95d5e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0daaaf8a-0921-4dd3-8f72-b8790e13a3db"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0ddfabd5-b134-42af-9442-d0117efd2572"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0dff4dc0-cc41-4b5e-b230-a0d7108fb023"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0e14d865-9397-413b-bacf-3ef7062dff25"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0ef10b6b-ac81-41f2-bc3e-bf8bef0b7625"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0f190f4a-391c-48a5-bea8-c9320429f7a0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0f3149a5-3f02-4128-a3e1-410d002422b7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0facddc5-b38e-47ba-b6ac-a9b864a082e1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0ffdb766-2695-47c4-9602-6fe9d7d1e167"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("10275268-0929-4a70-9086-f76734d06016"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("10797d9d-0018-49ee-9765-587639355107"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1110e697-fe6e-46dc-84ea-67225f38d628"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("11448660-376e-486a-a56f-2a314ba97c8a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("116e6127-3259-4224-8954-ecbc210e2fd7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("118351f6-df58-4cea-9cf1-b799a3a8f495"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1221efe8-2cd6-4c00-adc0-5c8a38404dc2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1222e752-b2b1-46cf-8801-d301ae0fd993"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("124524dd-9a35-489e-affb-8c3dee83453b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1254d212-f2a8-48c1-bb38-60879a1c7920"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("127adc40-0f7f-41dc-bbed-0d57abfc9a61"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("12b4b3b8-96da-45f1-9f4a-838ce131835d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("12bab8f9-606a-4c68-b4fe-edd736328b3f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1317b0a4-dbdd-4458-bc04-9c068f7fdaf7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("134c5b90-a1f1-4654-98c0-17c88c0d4520"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("136d4beb-39a0-4649-93d3-05162c214858"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("143db399-6e11-4149-ad0b-8af74c9c1858"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("145d4444-1f53-4813-95c6-e9fe445fe2c8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("14ead0c3-6f57-4b05-9ed0-74f47e9e564a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("154d54ca-4c86-4307-b81f-72e2f7e0605a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1564810e-b430-42a9-9471-bdf645b1d988"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("15c7cc99-3881-4244-bd98-77a0efb56475"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1666e785-cedf-47d6-bd48-dffda5bf7881"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("166b4785-77a8-4fd9-9395-aaac47afe73e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("16dbe01b-f161-4fe0-bc18-8ae20696be03"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("17249174-234b-49d6-a125-795323ab0049"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1755de61-0cf1-48a5-8cb8-2b8bac70f774"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1788f9e0-7521-4ce4-81f7-4e6943b5f5ae"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("179dce33-dae3-42da-b196-8af4b7c946f5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("17eb68a8-3c13-47fb-94b2-d156c10c4368"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1810fd80-1a68-4fb1-8cdf-08bb4f13f514"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("182482d5-0131-43fa-bc24-7783e3ea62c3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1831f67d-e70a-41a2-a7ea-432bc28c35e0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1877a0c6-1711-40c6-becb-8d8c60ec777d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("18843646-b502-4193-ab6e-15f06c4b9b8f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("18b313f6-5b9f-4fc0-b249-1b5db2a1bae3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("192223fb-5781-4729-a539-500f67634636"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1935a4ef-aae3-498b-9a43-1e0225bd837a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("194a91bd-3c6d-49fa-9477-27b18dd00782"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("199d5182-e4e9-402a-b49f-d916882779f7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("19aa7ea8-0777-4fb8-927f-75cb6d7bdbed"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("19d14828-e2d8-4959-9ad6-6bee4035deb2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("19e31d37-bf2f-4574-87a4-a159e8ebf9e5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("19ff24a6-22b2-4c9c-b7cc-4de79d51baa4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1a1d7b82-ecc3-474a-be43-56e0bdcc5d54"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1a3e2efb-33eb-4718-a6ea-4e60bbda32c1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1a685c6c-920b-4abf-abe3-e1a98febb62d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1a7289c8-2eb4-4958-9d7f-6f17c8725893"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1a9051a6-3751-4088-9fbc-943f00ab2eb1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1b336fa4-2cb5-4c4c-8c5a-96f6a2787629"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1b3e13a0-fc9d-4840-bf99-9fcb4cd29ad3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1b696a28-1eb7-4459-b6b2-0722c8f0049b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1bc9c586-738c-4d32-8eb1-eac4d3f8eb23"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1be2789a-92d5-411d-acce-41c23d13981e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1c073f02-1d2d-457e-858a-cfca83932c01"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1c3b6219-8a9e-4660-bfa1-88fae69e3f57"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1cbefad9-5b38-4d77-93e9-cf9ec257941c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1d43d180-f017-441a-a656-a4d7ea2fa1d2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1d4661e1-358d-4108-99ec-3b7fa430bfd7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1d6acfd2-ebaf-463a-b282-04b09e2d1208"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1d8dabf8-b80b-4553-a02e-091d3f146938"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1da41c1c-e48d-4e08-b931-41e5410c04ce"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1def29b2-b221-442d-b3a6-8be62c087e1e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1f842abc-e232-4d1b-8cfa-3fc339318007"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("20044fa9-39ef-4b8c-9973-39d57e0fbc68"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("203bb72b-5785-493c-9e5d-ae5075276557"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("20498469-fd84-4d85-877d-7ae586240a4a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("207888bf-f626-4a6d-be89-a5d2616d5723"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("20ef7b7a-0f70-4dac-a17e-800ab2ce9b29"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2157575a-4d26-412d-8448-f2c471597baf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("21bea758-5fd4-45d3-8326-8944a68533fc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("221a5944-bd09-4f69-9769-26a79ea74dbb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2231502c-f17c-49ed-a2b0-e14591b48f51"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("226b95e5-5065-47dc-b57d-2ea11f9f2a99"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2281c851-f04b-4ca9-bc59-393f0287c45d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("234ec62d-7f7b-4117-b9fe-27a198513ed4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("238682df-ce55-4685-8c12-279c7843b009"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("239921fb-0917-44c3-a217-40d34480fa5a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("23b088f6-3c12-4c17-900b-c7bd638d1469"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("23c193ba-7ab3-4620-9788-c0e47ce312dd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("23c8d688-5dd6-4347-a0e3-1547c4399296"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("23e1c3ff-e99a-4c50-9795-fc0df739ee6b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("23e871af-475b-4d6f-9e15-78afe8b257da"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("23ebebcb-b4dd-490c-86f6-553341c5504d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2409e542-b505-4a70-9ac9-005eff7a7354"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("244165a3-a96f-4ae6-a3dc-4f8672a71134"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("24dc02a0-deb2-4fe7-b3bb-1e82f8159a63"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("24e41536-c4df-480a-93e8-dedbe902b1ec"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("25c1615c-7d3c-45ed-8c0d-e1962f6e0e82"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("25ffdac0-71a6-4256-b3b2-8565583255ef"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2604c15f-bc78-4225-8bcd-17f2792fb972"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("260fec74-5402-423e-b667-ea618abddbb5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("26305ade-62ea-4b6d-a22c-7d7dbf9efd04"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2636cd00-c832-4a4b-850f-dd96ae92c6c8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("267776e0-5428-4048-977a-73c63a42e50a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("26fb0157-484e-4ed3-8fac-9d500e105f49"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("270f06ec-88c2-4e27-8051-be0b7749dffb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("27aa603d-2d13-4469-893f-5f27b86e647c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("27e344bc-64be-4dd2-823b-c90be89c3d3e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("27e8088d-4525-40d2-949f-4dd3346668f9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("27f5e16f-6c78-4c08-9828-262585a0bb36"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2842b9fc-c680-4820-8996-60f8d0763eb8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("288db679-39f4-4675-8dfb-ca3aa157c12c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("28a34215-7ad1-490d-b365-0677216998a7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("28cb0062-3e91-45c1-82dd-0b6e354c3b3c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("298e1926-0ddb-454f-8b16-3556f41066c7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2ae0ea2b-9438-4400-969e-bd2f60cc1216"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2b2ad4e4-f059-426a-8b25-270ee08239b9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2b442f6c-8609-4e2a-ba93-97d1b2826c4d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2b5a8a07-c726-41d9-bd28-b75ccc6ea6c1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2b8fc2df-7272-4b6a-b869-32291e53f09c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2bf8a009-cfd3-459e-9bdd-37b9053a1428"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2c00eb9f-f67e-425c-8029-d5e03bc06dea"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2c7c3b70-f27b-4a14-8b3d-9a02b4c47425"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2c846d17-d34d-4ad4-9dee-0f525afacea0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2c8b47d6-5c6c-4c40-ad44-b2d9f467b8b0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2c96514d-0a29-4f26-bbf9-1a592c6cbea1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2cce1d78-1566-4d49-9a71-a03651762602"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2d43f8f6-7990-4e1a-b23b-7e58da04cdd1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2dc44766-4d6c-42b7-a12b-499ea3177d44"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2defc1be-c8c4-498d-baf9-13133b75d635"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2e4f9c40-fb42-410c-b895-1052b6c64abc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2e8b921f-8938-4b73-b981-03ba70cd1f1d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2ecd9a85-d125-4e84-bb73-64de41c9d45e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2f1e1146-31cd-46eb-8e1d-463fc7c15a0b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2f8723da-88f8-4515-9c5e-ab6e9427a035"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2fed1a23-9b95-4acd-8052-fb86f27d16b1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("304b703a-bbaf-49e8-a912-b0c75d38cfc2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("30705c88-b835-4783-9f42-cf71d5ff333b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("30b8a5d3-1609-4f48-89f6-34664c3a7145"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("30c9902f-6df3-4f3f-b63d-0c60cd961414"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("31364a03-bfd3-4699-8946-13be30537137"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("317a0fff-b75c-4174-9e4a-db746dce4baa"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("317c5003-08e1-43a5-a859-eea41504e265"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3206fa3a-151d-4a96-801f-4b8c9389252f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("324110bf-d3e6-4c7d-b057-ec11b80fb22a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3267a89c-b60c-4cbc-92bb-61510229a725"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("327f9f44-01f1-456e-8ee4-c3f3ed92e57c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("329f2c15-2210-45bd-98ed-5acb210e5e47"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("33056146-4294-42e5-a8cc-eeb64b4a60a8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("33191e68-f805-45f9-9eeb-3e76e48f0dd3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("33192747-fd1b-41a5-9cc1-c2365c59bd25"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3338cc83-3f7a-442d-a30b-b44d5b6bf4a8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("333f94d2-53f7-4abb-8781-f59caad01350"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3340b4cc-1d44-4bc2-8eb7-7f6e3ee6cd43"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("33469e8c-fcc5-4926-8d19-4cbedb8fe462"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("33cf073a-9b17-489e-a14e-0b3904da19eb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("33f90976-e31b-4a31-901b-5b6d4913b649"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("340b939b-8c86-4ed5-a2d5-c5d4a171ee26"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("347b2ece-dad3-419c-b436-58f79a641808"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("34e5e13e-779d-441b-b8d1-d94b71984c22"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("35bcea6c-c918-49a4-a8a5-2ebe5a0a951c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("35c546e6-ce6b-4eaa-b36e-d05a7ad115ec"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("35f37120-4763-4de6-b4ae-6ae142798a9f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3624f564-6221-42dd-8ecd-839eab7432b2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3643640e-42f2-473f-aafe-ff078e951653"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3682b275-30d8-4457-8e53-49d8b6513bb0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("36e2effd-f3c5-4dea-bb35-ef43109d1b89"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("36e537ac-911a-4706-ae78-1b6aacc53b14"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3749f9aa-43ec-49cd-bd70-87fb9dd4c2e0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("37ad4596-f75f-458f-9a26-f589938cec3c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3814d051-5798-445d-9abb-bcfbc244cc40"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("38430046-4f8c-420a-9774-e7e1e8b3df39"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("389f7408-0352-4c8c-a71c-dbd5a8979f18"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("38d914a6-9ace-46ab-b678-e45475e0fbf6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("39705780-1af2-4ebe-ad63-a5174c1a70f1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("399c3839-90b0-4cfd-b932-cdb0633162f3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("39abd499-cd5d-47ca-a4af-f377fad6c214"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3a08ab64-6d26-4b8d-a5e3-48c534a17a97"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3a114e9e-590a-4df2-b0c6-3781bf59d69b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3a5a36a6-433b-4177-a1ca-ee8afb93695e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3a72b945-6bf4-48e6-9668-455cdef507a5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3a9d5afd-593e-49b3-a631-627d5d1b350e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3b2324f7-4f89-479c-aef6-946896b2e494"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3b3f340f-040a-4457-b3b7-b5992ec4e6a1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3ba6c467-ccc6-4fb9-93c2-164db821607e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3bb115a3-a166-4a52-affe-0a834a98039a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3bdfb840-f844-49c5-8f44-08345cc57796"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3bfcb70c-5bc5-404e-8d1b-504c934c21c2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3d240f0e-9e75-46f6-995c-55451935e3fe"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3d979c9b-ec6d-4b94-91a3-5d8791f22bcd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3dab78da-0d2f-405b-8950-c004bb99ac5e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3dde9c07-00d5-4dab-a112-c5332d1f5bb0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3e0b1032-404d-4f4f-9aee-1eff3f792df5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3e790263-13b2-4785-bef3-f5a5744c776c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("40d66088-731d-4069-9fa4-ccc003fb8232"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("40eca944-85eb-4e36-acd3-1b9fc474d206"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("41aa2c64-37b7-4970-a493-a6eeaf6a0794"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("41f8f433-2eff-4649-bbb9-79c9649f0eca"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("420df1b1-1efb-4396-8f68-b1f4f449c960"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("42161d5e-8cad-4215-b1de-8ebed66cc4b8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("421d3020-c724-454b-94ea-061919f7d329"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4222bbdf-6c27-45b5-9b20-8aef03801a5e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("422a85bb-1170-40e5-8843-c1ddfb9177cf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("42700385-5153-4745-9c2a-279db7f5ce6d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("428e2c20-80fd-4c59-8937-c1372e60782f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("42f9a73f-d65b-4f45-ba18-ede8382ce3cd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("43499ffd-7a9b-401d-87d9-91db7684f547"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("436aed0a-314c-4c8e-a025-56ffd35081eb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4371ef37-7887-4a6b-923e-04f9ade90cd8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("43e36b7e-eabb-4477-b1bd-9cc88a5b9e95"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("441d4005-72fa-472d-9366-66cdb1368e83"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("44a4aef3-e622-40ba-9900-8bad5b91e197"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("452d03be-5776-4547-9d86-8e58fa767e6d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("453cc63d-0f32-498d-87d3-19fe7e83650a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("45430934-ff92-47d7-b729-312e73ffe14d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("455b7b91-1821-4768-a382-ea53b5e79f7d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("45ec8bbb-c75f-456f-85be-620482caa408"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("45fe0cb9-dafc-431a-bafe-f5d03f061b4c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4605d4c0-adb8-411d-bc1c-fcc9d30cacc2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("462b9576-8ea7-4fa6-b5a4-9eba53d07c62"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("46724efc-8219-43fb-b811-eb97d37f830f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("467483db-5186-4af8-aead-a12f2e3aee40"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("46d99759-3255-4b09-a116-d6bafda7b9cc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("46f6cb64-eafc-4d5c-950d-b95c545381f1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("475b81b1-5b3c-45b0-8382-7e46c4c7953c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("47627b67-e4a2-4596-97bc-1ae74b3e96e0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4773554f-ce24-4f64-b08f-1a5475067010"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("478141c9-c18b-4b67-b0f0-ae8e8f18a58f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4792bd85-d949-4a9e-9936-9bc854ef692e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("47bf8ec8-fdf9-4c6e-bf04-306eefcd29b4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("47d4c930-21fd-411d-807f-41fa5173c785"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("481d9d53-eb83-4f99-a316-ec8ed88c2f89"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("483e5286-b6aa-4537-b35a-8bff8a38d2a6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("48bcef05-e6bd-4dc4-96bb-971a3352b3d6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("49b00c18-71d2-4b1b-900f-3e34e8eb721f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4a72fc9c-7083-46d1-9996-3293fb7d20e0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4a7c0425-f532-422b-9c02-fb4fee570d0a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4a8d1544-fcc1-4e28-b5bc-ad78a99e79bd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4ab6277f-0fc5-496a-938c-1a459a7dcd1a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4ab7569b-8604-405e-a8d8-48fc253dd579"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4abac99f-d0c9-40ba-ae4a-f9d4fe033274"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4abb1a71-e0c1-4eff-956b-ee039ecb3d14"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4b174b35-9a69-4a87-ace4-2079be86fe71"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4c43dd7d-953a-426d-95d0-7b42c7e4646b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4c5efa90-54cb-4221-8b4d-458d4dcd7373"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4c6ccc78-13ec-4bd2-ba11-c5437592c48f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4cd62df2-19df-4418-95d6-a3f153008142"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4d261b8c-d1e9-4217-8100-9ec1da22f911"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4d40e920-2baa-4dfd-85d0-07bc54205854"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4d456e54-068f-4a4e-a63e-9cc00d2cd80a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4d5242f7-af2f-4e24-bc09-ac35c7345690"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4defce2c-063b-4291-b44f-418a92ebcf3e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4df65a52-de80-4ad7-9fe3-bee407129e85"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4e185cb1-2f64-4181-91b1-c604d7b00321"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4e353a14-074f-4bbb-903e-bc2520819023"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4ee910d5-7982-4952-bffd-5506f2978860"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4ef731f3-f788-4b57-91e1-2dc424cb61ef"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4f0cd9fe-555c-40db-9ec3-e5bc0edf341a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4f9f39b8-ee27-4bf2-82cc-0ba1579346ea"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4fd0162c-17af-4892-9d5a-0afa8ff13eb6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("50354946-53c2-4c01-9dbb-f8d8dbfb9ef7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("50dc6dd8-e7d9-48b7-bb80-b6dece235e79"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("50eef3c3-68bd-43b7-96d1-27132c96c9db"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("51150e2d-47c8-471c-8d39-cfc57b371140"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("519712d5-8188-469f-9dd7-5a51f2f12263"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("51c5b4c6-a585-405c-8b55-c89fac3b10bb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("51cfed92-f895-4aa0-86d4-3e88c228764f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("52a454e1-6629-49bd-a6a4-7cef9de254d2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("52b75d1f-bfbf-4b9a-88c8-4714f15ad773"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("531157fb-044e-4be0-af50-62c166b3ad45"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("53326572-c557-495c-b41f-09d65432446d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("54291e69-979f-484b-973a-adb5a9eb7135"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("544cd845-a530-4d49-abfe-b7c3fea70581"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5539db9d-df55-44fa-9b54-2ce093df6a12"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("555af53b-cca1-46aa-a7c0-45e21aaae35d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("561fc3d6-3761-4185-9d03-566e4d9cc823"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5676a997-5478-47d2-956d-95b86d3d6859"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("568ad0a2-d4da-43fd-b432-8129906e0c3d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("56ab244e-0fba-4e59-bab5-f41805f1da97"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("56d45af6-6676-4724-926e-0ac360e04eb9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5829c7fd-d6ce-45a5-b4f8-c4ef4dfb846a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("583c4f27-cc25-42b3-a899-bc4ef59dc34d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("590dfc24-08d5-42f9-9845-96fc58d2132a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("592ea246-9716-41e0-9b0c-f551f2d06b9c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("594e9f5b-adf6-48c6-83f0-8e12b51ee28f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("596f0829-0735-412e-b346-a0ad8837d078"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("597e9c5c-d71e-468f-8ae1-671005a48cad"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("59cb37b8-4d33-401d-8b8e-0b5215a101e1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("59f4d903-b291-4c2b-8549-0065a2981c41"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5a4a0483-168c-4479-b919-d823d342b2f8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5aaa298a-5374-429f-a14e-8f478b2e8438"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5abadb59-cef0-4d73-9c68-26ab24d97566"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5b1b3b71-ab83-4af2-aad4-7803fdbc6d4f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5b37cbce-d5ba-46e8-8e43-38c2a278c624"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5b50829b-80bd-475e-85f7-83f6b044a718"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5b8d7a06-6809-4c82-9bab-723f39338f6a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5b938577-e8e7-4c26-a7a2-5dc115579002"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5bdeaa20-239e-4c24-af84-360162ec3754"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5bee7d2d-bca9-4be4-9bbb-81b783652b8f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5c11730c-2cc2-44b9-9ad2-7e63b5ed8477"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5c1bbfc9-b872-470b-b9c4-49642320690b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5c568f79-73ec-40ed-9449-1f9672e3a2fd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5c8cb082-d511-4ee3-94e5-1b89e7b1179e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5cd416ce-47df-4def-8c1f-b244340b2c5f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5db2aa75-8460-457d-b1f2-3089e3b366de"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5e048ab3-13ee-4419-a1bd-f8c3acc04cd3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5e632f31-1ecb-45b4-891f-f0bbb8cb57ac"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5e6f799a-2249-434f-8177-7788e353f2b7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5eba145f-f473-40c7-aadd-713e48de9c02"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5ee55ffb-2010-4903-99ce-8bc097e44bec"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5eef75bb-a554-40fe-91e4-169376ae38fd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5f29060f-ba0b-4a36-b074-ba61fd47df71"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("601e289c-85ab-4886-8f4f-91f5c6b35a78"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6028dc0d-f28c-4801-b6cd-b28d9e2107fb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("604c476b-704e-4648-b559-d9af1f2ca16c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("60dd2a55-9835-4a05-af66-5b5236a336e3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("61244bb1-19a7-4bfc-86d2-28288d93ea58"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6152a13e-649e-454d-9e94-683b254b6919"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6190133e-38dd-4865-80cb-8f7e05d5921d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("61d4b99d-9317-495b-ab8e-1acff64dd454"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("61d6d05b-9463-44ea-aa80-674a2b183b57"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("61e72f4b-4da3-47ea-8fd0-14f1b3b66e62"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("62e29be4-0c1b-41a1-a697-4939b72396f7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("62f43c95-058e-4a92-bc16-c0207e780477"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("62f6c88f-4662-43df-be5e-f1b9bbb1ede2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6301ef4b-177c-4f97-8b10-7fc9a64cf1a0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("630f3019-7b37-4f4b-ab86-71e3205bf176"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("63154918-c997-4e35-ad6e-1c5bc1b07b0f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("634648c5-d7d5-494f-9357-8065e98c6fc2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("638c5bd6-f3b4-4488-9bb5-5acb660101c3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("63bd0d56-23e4-44cc-a532-822f9ae81532"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("63d2306e-e8ec-4709-b319-df559c5dc8f0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("63e5efa9-c028-4859-a84a-71c944868405"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6484e95b-89b0-4811-9b4c-b42bdd695f88"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("65544684-03d1-46e7-a06f-5e24cec3b959"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("65abf50d-d081-4bf8-b636-e2de9c5af068"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("65c092f6-5dc4-49d0-acf6-c2f1ba23c865"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("65fe4f23-1a97-41e4-b4bb-cec553de67e5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("66382663-a3cf-4d73-a27a-e33167b34cc6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("66ca0c5f-7a34-411f-8945-fdafbbf943aa"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("66de71ad-2542-4d33-a69a-eae7a1c8acfc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("670ce409-522d-4ff3-a5d9-fda166cdca7c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("674e1360-bc20-48bb-b81b-51df44b8a8b5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("677cd29c-54eb-408c-8a9c-8b24dac80dde"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("67adc95f-4546-47e1-93b4-1af3e668ef5f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("681f1e1a-2b37-4136-a790-b054db8c352c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6838f80e-f55a-4d98-af02-78a4d76fd026"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("684c3f30-d0eb-49cb-9b70-9307967b16df"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("689e23b1-577d-4ab6-bb78-277cbb6fc6d7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("68e4f56f-643f-45b8-8ffa-9ef83a3bbd45"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("69227c2c-d676-4829-9b58-8bac43691bce"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("69788ce8-803c-406e-99f9-9a78d0442c95"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("69b352c9-5901-49b6-a507-46e03ec2e499"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("69f3a103-17f7-49e9-9ab6-634126abd716"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6a2bce7d-b004-41ed-abe3-62d11db0506c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6a49725d-51d3-4e1c-a198-c2dbcd98ee4a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6a50f437-de38-4a34-9023-ea5438a13f7d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6a661b7e-2537-422a-aaa9-dd1a092de59b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6a867021-91f0-427a-a058-e4695d71aaa7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6b90dcf4-e1cb-4697-b7f6-a1b79abcf723"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6c370067-ac1e-4a48-ac18-d9b33fbce3be"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6cb1dd6b-7dd8-4d78-b2b7-a0d945549fb6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6cb3584c-766d-4135-a9f1-da2071ec66be"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6ce25256-faad-4835-886b-e1b4aeaa9b8a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6d020a4a-2487-4b15-b33f-b9b7819a0df3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6e2fe8e9-7db8-4416-9a18-31d745a2c6ac"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6e3e5ac5-aee1-42ca-a0f6-8d5fd9bf5e9a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6e8db616-0b8e-4c78-989f-071d1f5e27e7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6ea1a5e1-cb10-4321-b9f3-ea532a76652c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6ef468ae-64a3-45e7-b120-fb387b353cfb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6f979132-bab9-4024-b410-e016482bb9ec"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6fb64771-88c7-454b-8e6a-98656010cec2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6fd6c2c9-b244-46bb-aa5d-f283b949742d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("70247a9b-9ffc-429f-aeba-7131df9cd309"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("702739bb-a216-4526-a8e8-a9fcd3622724"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("704b4d07-235b-49a5-a997-f1c49041222b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("70aa32e0-91a0-4b05-90b2-92191e2a03b9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7118a5c1-0316-4566-b66b-e8e062968f50"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("712e0559-b4a5-46fb-843a-da8a76f293a5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("71374165-9b18-4946-803b-46fbea69022c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("719c09d9-6f62-4eb4-b20d-4dce848a7e39"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("71d1de38-2ed8-4de9-859f-84074e9788e1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("71eb0844-b6cc-4b86-8132-cfb6410d1fc4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("71fb1f39-dd7c-408a-97bb-e728d71b3ee1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("71ff8301-c820-4d96-9716-c9f6d1b69d41"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("724fd5ad-7cd2-4776-85de-e2a5227ed488"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("732d6fff-46cb-4777-a37c-67eb5f56d432"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("73a4c534-ba2b-4f1b-990b-be6ee0beb542"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("741a6417-41e9-496b-a106-1b546c9ef68c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("74b8c654-bda2-41c4-b699-35af6f0140f7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("74c9fc65-c1c0-4bbc-a7fa-39625939696f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("74cd9c80-d33e-4ebe-838e-c8aebcdd043c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("74ea780b-f1a8-410b-bb09-74e747ae5f84"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("761e5e9c-7796-4da0-8628-fb39848053f6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7646a238-f674-4e56-b7d7-d68a0215aec4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("76cce0fd-84b8-4923-930c-7d64ea2c2d88"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("76f089c1-ce7d-4a94-bcb8-0d872c71d587"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("76fdd0fe-41ae-4cb2-80b6-fc8a953b4913"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("76ffab10-d343-4030-b2cf-7d3ec94fb307"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7728df59-bea9-4553-ac78-e0537dc73c01"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("777f1ef6-9feb-4135-aa5a-d9534f9c1071"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("77c49ffb-7c0f-45c1-997a-8388306ec391"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("786a3e6b-b050-4eaa-9114-c8d08562169b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7884f68a-e7cb-47bc-8255-e4ec04416296"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7884f7c9-cf8e-4d32-922e-5bf01c391d74"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("78855bda-2119-4582-85cf-8707c9a2286a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("789f7613-46c8-48c7-ae51-e670428a9dbc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("78aa4a3d-fa56-4ac9-83f1-5a30dd125325"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7913a97e-7321-462a-987e-b47dc3045768"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7949718d-689e-4689-a8a5-851da52690a0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("796ba519-667f-4c21-a899-f023d50e63af"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("798cf4a3-1d3f-411e-8473-2783b3d40267"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("79cfab31-b991-4df3-8427-aedfebd74323"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("79d4528b-82ea-4a48-903a-8a838eda2072"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7a1fd0d5-7285-4cb9-8ea4-0b2f56a34697"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7a681b70-f78c-4a2b-a45a-748fc4fad42f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7b1a88b1-bcd0-4167-8499-92774f102cc1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7b54b86e-2846-441d-a798-d57028c94fff"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7b746fd1-e39e-4d15-99a0-015d47c95b79"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7ba3ded0-58c1-4fff-add4-1703991e406c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7c8cac84-a175-4562-8907-39ea94ab6ee6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7cc48306-6302-4c83-a062-0341bf7bb757"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7da8909f-6161-4bf0-8832-db578d5e98a7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7dd60a2d-0092-4f69-ab15-20e77f201f9f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7e2992a8-1725-44df-bcee-7cb1b6ea4493"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7e52aa16-ddc1-46bc-9dec-25389d1e1dab"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7e7903fc-be2b-42dc-bd1b-2937b8eba51d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7e81b3d7-dd78-4a63-893a-40e29362e85d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7e935fcb-9c15-41a9-ad33-21ee5bdf149a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7e9ac308-1610-4fc3-882f-c40eb1efa62f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7edaa7cf-61f7-4097-a4d4-d5fb6ff244a9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7ee6ffce-3f0f-4418-92fb-cb4559465e3c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7f45cd0d-d510-4bc5-9d9e-5ecc199534ca"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7f66089d-2976-4485-8f07-eac50c94c674"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7f8a8c97-3d5e-49be-8dd8-cc8f55fc99c6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8023b2d5-2e3d-4986-a79a-83dc39ff6ce5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("80631c13-ac50-406c-bb6f-89781084488e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("81382456-c43f-4928-b5b1-5fa58cbc69da"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("81a9340d-ef3e-48d6-9082-cb0eb77b1bc1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("81b90efb-ce58-45e5-bbe1-523bf8afbe25"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("81be888c-b685-4991-bbe2-318d3a673b15"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("820c7f8d-d025-424a-9b23-6f8215b9badb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("82390860-92c5-42f2-bb51-c45e64a31fa9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("826a1684-7cda-4b00-9111-140833ba89e0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("82b01493-647a-4c23-98ad-f5b40efc502a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("82c0c341-4e88-4629-b0e0-bf170726c4db"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("82c861bf-2faf-4b86-b9c7-ee6336175332"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("83c66835-36d5-41ea-980c-81896494c815"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("840777fb-5eaf-446c-a2c7-ae40e43f232e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("84c1ac36-c83f-4ce5-a445-c4fc1517bbaf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("853731a8-71cd-4bf0-8bf6-f256d52198a8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8563f746-5598-4b18-a3b7-6b8857b76ffa"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("85a4bb75-78f9-4454-b4dd-53e4453a61d1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("85bd5ba2-04ea-491b-8265-4d6d3368e3e5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("865796a2-2f2d-4eb3-8b1b-685b874a6833"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("865d6ac3-08f1-438a-b903-2e894a6aa93e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("865fdb16-8159-47d6-bb40-94f66ced1820"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8730180a-52ba-41c7-8b7b-8254a09ca852"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("87313605-2467-4a87-b091-cc4d2238f126"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("87566aff-44fa-4bb8-a0d1-4d22089f14a1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("876217b3-a987-4ee5-811b-917962ca07db"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("878908fb-a389-4575-a673-20be5a2d917b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8794a9fd-95b8-4270-add8-287236bf4057"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("87c25166-4562-47e5-8e02-34323abcef3e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("87d4ad3f-bbd1-4048-9a67-691359c74fff"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("87d8a606-f439-4410-8920-487abf800a3b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("88668d7c-e7cd-4775-9d57-0fd0c9776e47"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("88a1e7dd-2d6f-41ed-99df-39ad8c71a5a8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8941849f-38e1-4e8b-b59d-0433b33a1c8f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("89dfda1a-2c8e-49c2-95f7-d0d006a0f754"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8a45af43-9557-4218-a82e-ed777d0f5d3d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8a71a552-c5b5-4cb6-8d81-913ec71a603c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8ad852cc-91db-4d53-8d7d-037105949488"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8b0b3df0-0329-4e28-a587-dd656bd647cc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8b0c6988-a418-4b27-8fc6-048fe81d5a2d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8b0fba5f-b82b-4a04-b5a2-7cda4148e940"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8baf266a-f998-4926-b193-16c1843377b6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8bc7a6dd-0f53-4033-8804-f7c2be194cde"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8c896bb1-0eb0-4dd6-89c1-4f4126e06ead"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8ca453c0-5d2d-4dcf-8eba-1a8a0aef0eea"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8ca96fd0-3774-42c0-9d6e-18dd875315cb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8cf399fb-f2e3-48c5-8f82-188132cc7cd3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8d50450e-9346-474f-b105-5393f3183f34"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8ddead13-8b78-4e63-b7cd-a2c5f0a54b70"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8e0df7c1-58ce-4cc9-9dda-e2361dea7455"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8e5f18ca-b69c-40f9-bb5a-43393b93caba"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8e6b02a9-b557-4c4b-8efa-23158b72ddf8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8eafa7f6-2a50-4464-b90f-4ee4044b52f5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8f41bd31-6729-4b19-9458-78ca6b488799"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9008898a-6854-47f7-b6cd-05f9988b3f34"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("902dfca0-7aae-4edc-ba88-3f875c225ae9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9039bfd2-1776-4a59-927b-4ac2b6601eb4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("905d1bae-c54d-4c12-bfc2-964e29d3a950"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("905fc9f0-80a5-48b5-b975-62481824229d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9073b896-5a91-4786-a412-20b8a7a4ecbf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("90c422f1-6d7c-43de-82bc-731b9d82388f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("90da61c6-1727-49af-8ae8-0c8ce9cfa8f1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("911ca2e1-8779-4e4f-b5ac-643b55497bbb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9126b6a7-a7b3-4259-b068-61026c76a094"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9165ce54-69e8-46e6-950b-e1415c74b3c5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("91853e1e-c9c2-41d9-9b77-a30f4eefe865"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("91e2a24b-c79c-4a5a-b00a-c7a30b1c11b6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("92471b17-ca99-4a19-b6af-59b944ecbc7b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("924ff903-167b-4f8b-a4f9-b5ed696546b0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9268823e-37f9-436c-bc7b-5dbb548d114a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("926dd1c6-5476-4f81-a669-f7dff4ada9ac"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("93188b0b-0791-476c-8420-3fb1d9959ee2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("93642a38-c448-482d-9deb-de7300e5161c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("936efd14-97f5-41c8-a403-2cead8de191a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("93b2434a-dbb6-437e-88bb-a32a125f7b5c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("93c49b6d-1298-4f1d-b10a-037c3870f002"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("93c4a3d7-ea23-4a9a-a776-83fb4db0e830"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9422c6be-e44e-4b55-8080-aadd437c375e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9441ff30-4d6b-471a-885d-afaffdf9d891"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("94d63b81-a1b7-4f27-bb21-de8ea3274942"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("94df9105-b2ac-4aeb-a018-7b91bc4e2de4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("95446d63-a163-4261-a522-ea07ae8c4222"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("96446c41-d73c-462d-8305-934a06324c48"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9684fc0c-9c2a-43f0-b70b-0a27cd31ec04"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("96c8009d-d875-40bf-8449-887d9dc78db1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("971e8826-0fe6-4665-8c03-63bdbf1b389d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("97fb203a-8223-4692-9d85-0582174bc856"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9814303f-8a9f-4c4f-8799-826ddf5e4763"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("98722d30-f30e-449a-87ed-b5c529a003d5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("98733858-bbd1-47df-8e94-baf67ddaf314"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("98aa8541-dd26-48aa-b474-6c591f400235"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("98e93f91-a002-480d-a349-2120943d75cb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("98ebf3b2-742e-4edb-bac3-f774a4179a8c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("99399d56-6bbf-4760-ab85-5c14a7eac1e6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("995cfad1-0630-47bb-912e-817cdbde2457"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("997c7913-b3bf-4995-a14b-e01a40387a4d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("99837bad-5b4e-4e3e-8610-865c3d8f70f4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("99bd39a5-75f8-45c2-aa57-957e39882ef9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("99bd5a77-5779-4804-8d0e-069710f89205"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("99d72060-6009-46f0-a2d2-e199bce3a3a3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("99e02870-04fd-45db-9f85-f0d387bf59b8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9a14c545-d635-4acf-925a-d8df3da4bade"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9a5db2f2-43b2-47ff-b174-9fb9a04e305a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9a669fe2-6e4d-4b60-82c0-bc538a5aa954"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9a8bbba6-f232-44a7-9d73-9666deeb75d6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9a9b394e-501b-4f87-a255-d94d6ce1796a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9aa92606-1877-4469-8787-762a447660ea"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9ac09f03-6fa8-4be4-8a58-6477589bf41f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9b1b0e41-dae1-4f78-ba73-607f1f78b007"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9b1bb160-c346-4cc1-b403-c1b6ffb89007"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9b60b64f-97c9-426f-bf05-19505d87fa99"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9b891fc6-6b92-4250-a20d-8880c512ec83"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9bc812bc-78e3-42ee-b7d6-a6dda00461c9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9bcbfb93-0519-4833-b850-c34619a898e0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9bcfa2df-5cab-4283-bcb8-259ae8601e8e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9c51b764-53ed-4e3e-a8e5-44105fe589e9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9d0b4012-f2ee-4e68-b95e-a799fbd5e9b6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9d6a223f-a820-40de-81ea-52c239dd0a5e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9d6e4d0c-f5b9-483c-8a62-94903a84c5d0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9d775ac5-3a0e-46f6-af73-7edb09ff8532"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9da9d6f5-4986-43af-8604-6550b910c079"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9e2eff85-22b8-4bef-b37d-73bea14e34ae"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9eb7ef07-b48e-4fe8-a236-c59b9491135b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9ebb2e7e-9a3a-4def-ab20-03b257739405"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9f03dded-5e9b-467a-8992-adf092a30725"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9f1e6a4e-03ab-4a70-a792-c95ff39ed050"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9f1e83f1-dcd8-489e-bbe0-a6561d563808"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9f422c24-66e5-4fe3-848b-2da79c2e0430"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9f54c576-7cac-4344-ade6-2498e1b524c5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9f88d572-5bac-448d-a220-1dd2cc63f73e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9fd548dd-98b0-4919-962e-9ce836d82322"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9fd9534c-816f-4552-b98f-a4d7ab8fed7c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a0013a7d-7814-46de-8a3e-a46b7067457a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a02a6149-1b92-4ba0-b9b7-4eb2574853a7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a04998f6-49b9-4796-9f9e-74af7395ce97"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a0646105-a6ea-4c06-a050-bd0c876ce9d4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a0829162-f9b7-43df-bbbb-5dc46d957417"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a0d69d5b-fbd6-4b0e-b173-c1817cfb231c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a0d7cb9a-36e7-4c30-954d-d2856ea09df3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a11e131a-d3e0-4080-ba6e-b4645c2a98a9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a132f1bc-943c-4a2e-8a5b-d087229f6b56"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a1507047-5019-4d74-bf94-a8d5129c100c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a1984bfb-16b8-4d8b-b21f-c07105a5cab6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a1a31114-5e3c-4a75-a28d-3fe334d7a956"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a1af1e7e-17e2-4f83-87f9-8ad1a9362209"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a2294e35-d339-4f97-b7f7-1172d120808d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a23c4995-f7ef-47e4-ae1e-70b2c96ae9d6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a24c022a-4de3-432e-89f7-0237ba033fbc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a2603ed5-dc69-49ea-9f74-1899ebb854c2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a31e402f-c325-4e07-bc24-d210645639f1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a32f3e71-ed70-45d3-9246-bfcbb194c7fe"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a33a2b9b-f3a2-4a09-9d6f-3189dc14a791"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a34da11a-1bff-4e34-a664-a572a7b9a5d1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a3b3fd53-1596-4e2f-b042-6fb2f636fb5d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a3b9d96c-fc73-40b8-86ac-dd8b726541b4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a3ed22fb-d331-49be-8043-74550f352e05"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a3f8c9ea-3300-4ea1-ad23-b2c96a8dde94"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a47c2682-f5be-4aff-96e0-ff818391fca4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a4db058f-6f80-41f0-bebc-9332c4db1980"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a50f2b76-c17d-4151-9dfc-ba76d83aa83b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a51838e0-6cfe-47e9-94a4-a5d8105dd405"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a538f494-5391-4bff-a8d2-ac355583ba04"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a5913c12-c0d3-4640-83c0-457f415ebfd6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a5b67dca-80a4-4a0b-9f77-eee9c878291d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a5be9347-ead8-404b-a2dd-96ecdad51f2e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a5d9f796-d4fc-437a-afdd-c468ee9efd9c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a64cf12f-ff51-4858-aba8-cbc7723f186c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a664baa6-e5c7-4a2e-932a-847bb2963e7d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a6b30548-6a76-4617-9d15-a323a423b206"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a6d9436f-f98e-477a-bf38-2b9d5b053ec9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a70c5e9d-3773-45f7-bd87-071983829c55"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a728a032-dbc5-4233-9080-e6dac8651620"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a7d4e5ff-3736-44e1-95d7-a82d9f115519"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a806a3e9-5ded-4af5-bf5c-e4374e560035"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a85011ac-b7f4-4a3f-a23b-cd59dee0d7e0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a8585f9c-f843-48a6-8b18-3f3eaba22115"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a8834c72-f7ab-4df4-8ebe-66c3e4e6a4ca"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a89f1faf-008b-4711-b2f0-f420d1641bed"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a91f32a6-e41e-4b0c-a186-9cd5791629bc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aa42ab59-c4dd-4ac7-ab94-047638afc9e4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aa53a84b-bc34-4d05-a3b5-2a071c543e40"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aab81f6c-ef2c-48b5-b27e-90c223418017"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ab0bf74e-7472-4b18-95ec-32b94a895b84"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ab2514e6-24e1-4d2f-895f-c19b5be549ff"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ab298857-93b2-4822-b349-08c03403e035"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ab71a035-c3fb-4dca-ab81-8a35616b3d08"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ac4580b7-0a45-4f70-920e-9e6f5d726c76"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ac7dd4bf-6143-4bb1-a094-774a0fa5303d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("acb0de8b-b4db-4ae2-bdb4-83b16a952918"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("acd952c7-d421-475d-844e-3d1dc2098d61"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("acf110c6-4b99-4b20-818e-96353d930dbe"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ae5efacb-e2ce-457e-873b-4f57415db12f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ae74c9e0-80ec-489e-be9e-b0ff09e6628e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aec5d461-87ac-4df8-8927-3ec965f12066"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("afb47d0d-38eb-41eb-bc43-1f3f53513e1f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("afbf2d18-aa7f-4733-9287-7d5765d88f1f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("afc57245-1e7b-4ddd-87a7-196b5b836c1e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("afdf06be-24aa-46a6-8a15-a408990cd12b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b05b52a0-6483-4ad7-b9f7-b6875c1b5128"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b06be099-48da-4ce1-8197-c0c97b798f11"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b06ebbb7-1aec-47fb-8095-0c9ba676cded"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b0b917be-019b-4684-83be-001de1ce7895"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b12e2b2d-83a6-4176-af72-9c2b39a2f94e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b13da954-0322-40f1-afc3-44227f64a287"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b18432da-b13b-4acb-ad51-bdbb38d182d6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b21c0b30-ebc2-4000-bf2d-c8407139d087"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b2cb2301-813c-41f6-a6d1-d3578c2204cc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b2d202c7-e0a0-4628-b07f-dffe43f05483"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b2ed0f04-7cbd-4891-9da4-2edba246a1a7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b3404043-1188-4485-872c-a177cbb8a944"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b37395d5-8f51-4d87-8462-a46a9c5befd7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b37cc56f-6751-42d5-b2f6-de08e5f15b5a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b41969c3-f5b8-4067-b961-ab61b4958d9b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b43fece2-00c5-49bc-83e2-b5e96ff124eb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b475e13b-8d03-4f54-9867-03352d49cee7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b492d5f9-3fbd-46d4-93e7-f108e88de1cb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b4a99bca-b5d0-432b-99e5-52f600726b2c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b50eb6bc-d0b0-4fa1-9d31-b4c88a260f3a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b5211b3b-4282-43d4-8209-98126d42e76a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b526a2c8-85b3-438d-8a15-606b28e08300"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b548141b-0823-4688-bb34-9ead0f130e62"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b56e540a-a6eb-4022-ac29-23f07552b710"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b57ff734-00f2-449f-87f3-f8357abeb8c3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b58ffa5d-ad9f-4215-819d-b0dd03860143"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b599d758-24a7-49ef-b1df-8d98dc64c881"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b6b6eea9-5036-485c-beb4-8e783af7b473"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b6bf7b38-9b82-442b-ba56-9a6d4815fccb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b73aecf7-0599-4ba6-8132-398e97f5a27b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b773ba0f-8bfe-4c61-ae6e-56eaf1351eb6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b797c58d-3a65-4060-8621-5ec075cbed39"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b82f3c96-7b02-426b-85b1-2d75401472ec"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b89fd72e-9f5c-40e2-8a9e-c675faaa41e5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b8dd92e3-fb2d-4d11-be35-ad0c22559fdf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b91f6c75-5a29-45c9-bbcc-2d3dec4e1a1b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b940051e-e2dc-4e32-b9f7-1f9b439e46a3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b954b7cc-4067-4e9b-8caf-206d1f833553"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b97d131b-8d89-4a9c-993a-1fcc060155ed"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b9e6df17-67ae-4844-83a3-badb845e0fc5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ba9efebb-5931-4584-8e5c-8c18ed805288"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bacd96a2-c9a4-4f5c-ac8c-b8149deacd53"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bae70b86-786a-4728-a5aa-a0c2f07bde54"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bb357f27-2632-43dd-9f0b-b946b7eca557"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bb6f8f78-4d32-4635-ae63-80e0d46bff60"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bb91f776-8bd1-41e7-ab6d-63c54cc6162c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bbbe88ec-aa73-4dea-a4b9-5037ad53726c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bc141fe0-2e8f-4ef2-a671-454a76576ef8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bc1c90bd-7ff7-4a82-9a8a-fc5f68703d68"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bc56c3f7-c2d8-40f0-9867-048d9496162e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bc9d8d2c-4c88-4588-90e6-ef7ce7ce155a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bcd58202-64ab-46b6-8063-29e8edfb7d79"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bcf78a30-f2c9-4d85-b803-c5213cf07434"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bd9e7115-1cb4-4f61-83f8-cc282d62a303"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bdabc74b-afe9-4c90-a46b-5c1e72d209a3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bdb5ceed-67bb-4f7b-bc6b-05110c17f4a0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bdcfc530-90b7-4e1c-9967-be57e81b7b2f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bdd9d1d7-1f7e-4e07-8367-101ca8801eb4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("be4c4792-86f7-4107-aa1d-0d46c32c5199"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("be9857a4-8ff8-4428-8d53-1c5a808fabd3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("beef1bf2-ade5-4564-865e-c668f7538332"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bf09b3f7-93d9-4682-b01e-1b65d37a5fe1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bf4cf67f-b38a-4c23-95fa-4a9e5568d42d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bf74e759-e2f5-4e71-b665-351d8d211b0c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bf8f9f1d-f095-4fc5-9faa-936f2f9c8e92"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bfab3f5f-4082-4008-bf96-f1c52a59e2f4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bfb55512-e8ec-4a30-b445-8f33a7e57068"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c00e1d0d-506b-4a46-b1bf-baab20e3841f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c02721b3-a1c4-41b0-b8c1-3b9dcd1ca274"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c03b213c-9b3a-4372-b08d-e8310134942a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c07839d0-7280-4fb7-84fc-095dd2f16b01"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0b7279f-a0ba-4279-b1d4-8f0136ff9b7e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0df9fd6-3757-4b88-963c-50dca81f8ee4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c1841766-1afa-4054-8cb9-c46e18847813"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c18e30c0-8c0b-4cee-96d6-25c731867c75"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c1ab6b60-57e2-427d-a0b9-7a6ad40fe9e2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c1ae7f0f-844e-43e7-9400-da4ae0b7da29"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c22f8006-febd-4e46-a903-75d3f86334e3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c24237f4-db51-4693-8bcf-30075ce83495"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c2e68861-d9b9-4006-a5c3-9c4529dd39e1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c332d8fe-61da-46a5-85b2-c9569379e1a4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c3397b90-5686-42b0-9ed1-9312295cf708"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c3ef6574-5002-4c04-a472-425af1fd67b2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c4560f23-e43b-42a4-93a0-b918b04b4faf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c4d61c39-2590-4e1b-b78c-a510fcdb51cc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c5522c6e-3c82-4da6-98f4-c6cac45829c0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c5685730-eed6-45cf-a935-4cdff1f78acc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c59da5f0-5ffe-4809-b577-8e3d483be239"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c5c05dc0-79a2-4757-8039-e6a7dcf5a1b6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c60abb8b-a9af-4163-84eb-2c3934cda79d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c63dc555-756b-4e03-8c89-9b1324759871"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c64642f0-7c21-4e48-8b77-8ebc007e51c6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c68df755-ef10-429c-b048-cbd9bc0273de"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c6c75178-6da1-4f89-bbbc-5ea8d0c5c61f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c738f466-7450-4489-b033-744f0c3d8d3b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c763d33a-05b8-43c3-9621-5711c6ddd20f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c7a20d1f-60c9-430f-b918-14c5192a5dcc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c7e3b0f1-484f-469c-a020-f498726ecb91"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c7f24c15-35f5-4246-a778-6c81c802d9bc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c8305ceb-5404-4f43-8189-a324f2d074c1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c83796de-0400-4d06-8410-ecdb83981c09"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c83b4b32-5157-4e9d-9524-fd2ae4ce2b09"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c841f88c-aa3b-4935-8aec-5120925b4f4e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c84cf139-d2c0-4262-8ace-4fa58d9855c4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c8f86d1b-ac99-406b-a79e-f2af427881c0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c9635ef2-1498-4cfe-a105-d07318749c02"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c99e4a3c-27f2-4485-8682-84cca17f2981"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ca2e8a99-067a-4532-afbd-eba5a85bf2a0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("caddfd92-d138-4202-8036-24f672b65b69"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cb20b069-37a2-4373-9f88-8db9adcb405d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cb339de6-688e-48b2-bb54-63e5e10ae0be"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cb603075-f5bb-414a-b299-a8c14eaa5180"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cb88cba5-42d2-4488-ad74-0599a86ff2fb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cb9a6a17-a3ff-4b30-ab03-ba0a0377104a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cbe7daae-07d4-4f76-83f6-40c0fb58c950"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cc49f360-5a86-467b-9e64-541abd8d3b99"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cc92825f-b360-4b27-a5fd-50d9d93b6158"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cca6917e-3b29-4e33-94c3-14ed35f961a7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cce9c356-473e-4d5d-b95b-487f90ae4580"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cd82c750-d992-474f-9dee-a3c06f99c85d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cd8af7d2-9519-4913-8efd-42c4c3b0dc5f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cddbae2d-91f0-4185-aad2-c968ab9d131c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ce1b20b6-d116-40fe-a31f-470cd225c995"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ce6036d6-510f-47e8-8bf4-255bfc7a99d2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cf13ced2-27cf-474c-a764-55acd978ee6d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cf266084-fb11-46da-8099-e9977798a4df"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cfa82c74-9e9d-43c9-855a-90f5db0df3cb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cfb21d61-40b9-4358-8bb2-f743367eede4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d00908f0-d0be-4cd3-885b-7cac0dafe5e4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d027493a-428f-407d-b275-03780462dafd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d0e16f5c-3ca3-4327-b96e-173c69f17a3c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d102c8ac-fe22-47e7-b47e-1e51cabcca76"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d115fad4-643e-4962-b2d9-715734ec1b47"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d132052a-264d-4643-84a3-dc31666710de"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d13c8be4-e320-4496-8473-293e9276af5f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d13c9826-c6e8-4c14-863b-5e2ca6ae821c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d23aae7d-81ad-4d48-b086-813201fffb8f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d25f544a-70ed-4f04-80b3-4c2ba1cdce72"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d28f7696-8553-45f1-9550-38db218a8f59"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d3a5e21a-4a41-480b-8c87-3e35b5cfcf07"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d3cd727a-ba1f-40fd-8f0a-293466624752"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d3d48b47-ba5b-4983-99f0-6ff4f855ab27"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d4169217-6912-4979-ae21-293a39f494ff"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d508ac28-84de-47e6-8806-591c44c78331"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d5a08be0-8740-45c3-8eb6-072c6edbf4ac"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d6060c64-29b6-4a9b-802e-6fc872ce52e9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d6144dbe-483d-498f-9e93-b2592fe113b2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d6462e89-29d5-417d-8a28-7fb3a1da4683"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d67334c0-f775-4a7e-86f8-6a22fbb81305"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d6bdfeb3-3d4e-4a82-818a-0a81220c7738"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d71f5d09-67fb-4b13-af8c-fcae3e33c757"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d74ed632-e803-47ea-9ee7-357c56bd8b2c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d78f0667-7309-48d7-8bb4-bf7d6df91d2b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d7d1c62e-f138-428a-bda4-4af1b7300348"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d806482c-60fb-4a2c-9a74-729694334243"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d82a8cfe-9c41-4fd5-bd9d-ca68732b6fa8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d86aeb2f-505c-43f2-9354-a47f58713c86"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d8d3530c-7a16-452e-93ef-3c35d9474a31"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d929aa1e-30c2-482d-a494-27b0b05f3408"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d92e6bcf-f5ba-4bd1-a0a2-cacb9070717c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d9417dcc-6555-4eba-b371-12a404d83f51"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d9811373-4dbd-4511-a288-6b9fa8496650"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d988d56f-f708-4f6c-846f-535a2f8b2d39"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d9de8031-1fde-4b3f-96dd-5415202097f9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d9e7dfbf-ce8d-43d8-aec7-2a265bb8e5b1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dac0e757-f35b-473c-b049-51fe21126bbd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("db0c8125-d6f0-475c-8782-489641493413"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("db6d6a3a-0aaf-4af8-bc1a-48112885be12"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dbd5531b-1ab0-40de-bd18-612b6fe8b626"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dc38e31e-4ca2-4294-b9d5-f26a4aa31d8a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dc3b6e94-d47c-4c1e-bd12-823865b5afce"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dcaabe1e-2b0c-4cc5-a084-3e96a9fb31d6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dcbeb8f8-89eb-4c5f-9327-0c551bbf451f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dcf28385-342d-4658-a0a2-ee6edee46da0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dd3cbd93-6aac-4221-be30-a5b6fe3f2fd5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dd6cfccd-ff4c-4e42-b8b9-941a17899a00"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dd7b6d6a-8a22-4de0-9084-4cecae9c8d6b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dd882570-869d-4fe9-9eb5-1c316c49133b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("de075d74-f7a3-4896-b90f-89c407b82c2e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dedb5b35-4d84-48d0-920a-b5dcbcab5885"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("df204655-c201-429a-9b16-e01f6a72eb60"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("df315afc-c570-4cc7-9fdb-060d2b99c90d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("df3aaf62-ebdf-49ba-a729-d0252c42187e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dfce11c9-9adc-46c6-9fe4-f810d6c805d6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dfd86d42-9ee2-4477-80b4-8e7fad3680b2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e06f7678-b589-4203-8e96-9afa6e27a95e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e0cb0435-878d-41f6-b311-42f78ae685b8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e104a645-2d97-434a-ac83-6fa73b6da4ff"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e17c9886-8cc1-42dc-a050-d4897ed29144"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e19934a9-aec0-4418-9ba2-b9b4268894fe"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e1d3a621-c47f-43ce-9dc3-56fefe6e0b7e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e27c5b9f-3490-4bd8-9f83-a989f49af5e0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e2d0af86-7be9-4493-90b9-d66240b3157b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e2e5ee3a-8ab9-4973-b684-32b27e1dac30"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e307e764-b2a1-4ba5-b41c-6c0a9702e635"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e31fc6ee-3987-4c16-8079-c94302454980"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e32c034e-7091-4e52-a7ce-d389a6f16118"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e36d0a60-58f2-493f-aeed-59ec3ca39de5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e3bc0989-a4b9-4977-870d-10839c2fd476"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e3c5a8fa-0f36-48c8-82ea-448497d45ec1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e3e7d992-2019-4b50-8a36-86ee61ad9c0b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e4049709-0ba9-4ef3-b6b2-c5dcef62606f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e47f4100-cfb6-48b7-a851-facfd8b423a7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e495afe2-e0b4-4338-8cd1-fcd0a7bbcadd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e4b880a4-5fe2-4576-9052-a7d6ed80c4d0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e4f0255b-3ad3-40b6-a4dc-f622717907c1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e54a7ff5-2164-4eb6-8414-62b09fe557f7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e576f796-67e6-49e2-aed1-f6df46f0de89"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e5820cbe-b9ba-412d-ab57-d9a6c6ad3ab9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e5d9a6ef-e6e6-49ac-9a8a-537360f54e18"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e61f9450-0843-4525-a0f0-29208111e8d1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e62eb2ab-3b60-46db-826f-3a0e58d8f27d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e63f303a-56bc-44b9-98d2-b9b96fd2cbf5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e704e897-e75e-4de5-b397-bd8a6e4bb0d9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e73d5f63-2662-4408-956d-b4f808930712"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e7880329-5596-46d5-aa58-34023cb3a894"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e79f6673-fed9-486e-b18a-e52ae6c438c0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e8356f03-168c-431a-9817-65ab79b0b3b2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e843d65b-286e-4001-b288-34c8068375f5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e8508bd7-44bd-4451-a1d0-104fafe4e532"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e87755c1-bd62-4cda-a6a5-58155f6b48a4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e89d5cc7-f52d-496d-9229-0c995d093800"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e8b5842f-7711-4a96-a537-003e7c1cee1f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e8f266a9-39c8-46f5-bf5f-a381d565347d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e9421813-ac31-4ef8-a732-e12eae0ef90e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e97238fc-261a-4b9b-85a0-8b0425ec0e1b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e9883c02-661c-421d-9654-2be3e87f1989"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e9cddea4-33cf-4999-b960-84a859385991"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ea4872c4-d780-4795-8b43-e84e4499c1f2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ea4b0c7e-df04-413f-b9b0-c30eb5cbfc3b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ea5ac026-0393-4a3b-a338-998de9871dfe"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ea70f751-cb62-48b6-b020-f35d77d3df27"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ebe909b8-4d7a-45de-9bfb-c4520732c6e0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ec181af9-dd29-44c9-b086-de1bf97bc435"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ec747907-1e68-4b20-a577-c0cc1199500d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ec8d67a5-8adc-4d35-b8d6-00fef7635a90"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("eca81bed-dbce-48e8-ad3c-79c1a41e7833"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ece0c277-2a70-4f61-bef4-1111c351cef8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ed337da3-1204-4408-8378-2e96cb1da940"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ed784d4c-a0f4-48eb-952f-8baf0abd9c7a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ee6df4d6-e93f-48e8-8a79-5fbe9a65c34e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("eec78767-59bc-4e0b-962a-f54de5252755"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("eed9c050-cac6-42c2-b525-8da81924fe0f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("eeec961e-7ab6-443e-81e5-470a91a211f3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ef0b33de-a321-43b0-8f5c-c198e08556f1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ef283239-71cb-4dd9-b50a-e49c7874fc9f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ef62019a-b991-4436-8b6a-98d2d7de27db"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("efc1adcc-2c2e-4439-b97f-edbdf983bda2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f010ba96-a815-4415-b670-cbc2728a0ae3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f014183e-f963-48e4-9de5-88df0a62a23d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f06c7885-95f1-4030-879c-3fd220a4053c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f0ed1805-63c4-4f7d-b25a-1932e36edb2b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f137fb5f-5e94-4467-b286-9ce3c885a812"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f1769adf-7151-4426-b812-359bcc533750"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f190b293-bbc8-4239-ad78-8ba707db0ac7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f1a776b6-b264-41ee-a6ec-b54e76da0a8b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f1e54c8b-aade-4979-abae-170bfde534e3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f2549175-5cd9-4d0e-8d5b-2d5f1cab3e47"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f2579d04-d534-40df-9f54-17b7dcc89ce9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f2a195bc-d16e-4b12-9d3d-5e8f074b7e80"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f2b9d5a8-00a6-4976-9cbd-8ef362b8be69"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f2fac153-2aef-4d55-b329-4991008fda1d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f2fe134f-0eeb-4d96-8ce3-73589a4eee5f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f32d370b-1a4c-4a25-a841-3d43e1c7d623"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f358abfa-27d1-42ec-951f-64e291dd3e84"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f3772a6a-846e-43aa-9652-4214d931463f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f399fdae-2183-44b2-86af-4d6bb31bd0a5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f416aad6-ba1b-46ca-8d8f-cd1bf3538def"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f42914be-76dc-4dbf-ac62-d57d2947bc1b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f438c888-2933-40cb-9a77-0df59f93bc4b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f45f1a86-230a-40ba-9823-e68fb43cd07b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f49ca7bd-f72b-4ccf-960c-75489adddff9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f551ff28-78de-4eba-9e9e-e60ee86f52ec"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f5a64c91-6d3d-430a-b682-6285de8cccb0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f5f592be-a93b-4c64-8eb9-a9eea7b60902"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f64d9d3b-56df-4ca3-b3d5-810a240c746c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f6554208-9e98-489c-88ec-8d89285d8222"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f6c62795-08a9-4779-9790-faa1e5687541"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f6dc3cac-03bc-4714-853d-2abde3d38cf8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f7275cee-948e-4c3c-a9a9-fcf4f49d63cd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f738362b-f905-464f-a320-aab402594964"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f7637bcf-92fe-4f57-8e41-517789ec8c43"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f76c5d48-6023-4590-8a0e-dae61ef2e09c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f7753fd0-abc5-4b93-a402-1a4f3c869ed1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f7973410-aef3-4229-846b-f6ed87e5cada"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f7f3212b-d277-43d8-993c-f2a4d8a730b7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f7fad7ca-105f-4c91-a5d1-757a5f88f270"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f8130449-75e1-4a2f-9125-f63e4517f0e2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f81e90ad-f78b-4b7a-a2c4-c1067f61a9b3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f89bfc82-8672-4fd5-b01e-f45ed8ce329e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f8fb8f4c-6046-4c59-aaaa-8ab2db455b2a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f940b00d-f384-4bda-b396-5e2f9d849b8a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f94f681e-e282-490a-ba84-853be009d826"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f990b05c-ac0c-4e60-b43b-231b2c9af99c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fa3be739-9812-434c-97d5-9556c0c624a8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fad54e3e-7715-445f-ae16-e80157258a62"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fb8ee40b-cdcf-465b-8cf0-a719f47f29eb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fbb08b1c-ff7e-480a-b74a-5c21a472e73a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fbd3a0f6-1351-41bc-a0b8-b516207599bb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fbd81b35-0516-407b-8424-72b3719a7950"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fbde8456-6ee4-41cf-b889-01b4cbf0e9e3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fc733fad-94e1-4e94-9da4-05f8b7aab4b1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fcc3e3df-93ab-42c2-90c3-8b7221e5df44"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fd4801bf-d020-4c6b-921d-81b52f46544f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fd932b99-a5e2-4625-b92e-98c585dc4537"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fdac9aa7-a594-4d85-9fd2-28202218f20a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fe3502fe-65ff-4743-a668-38ebe5637f00"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fe6e8c43-27a7-4ae0-a533-c288cf5feb91"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fe7adf84-da02-4181-96c8-274f7507275e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fec5f6f9-1c65-4075-8367-e6cabc9073f6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("feed08e3-bee2-4d95-bd2b-f79f3cb63e2a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ff01f31f-3e5d-4af1-8e94-c4018712072e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ff9582b4-9cc4-4384-916d-9b9d84e76e91"));
        }
    }
}
