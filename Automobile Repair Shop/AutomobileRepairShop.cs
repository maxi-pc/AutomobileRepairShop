using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Automobile_Repair_Shop.EF_Classes;
using System.Data.Entity;
using System.Diagnostics;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Data.SqlClient;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Xml;

namespace Automobile_Repair_Shop
{
    public partial class AutomobileRepairShop : Form
    {
        // PROJECT TEAM 1
        // BY TEAM LEAD MAXIMILIANO PEIRANO
        // setting the context for database and the lists
        AutomobileRepairShopEntities context;
        List<Client> clients = new List<Client>();
        List<Employee> employees = new List<Employee>();
        List<Service> orders = new List<Service>();
        List<Vehicle> vehicles = new List<Vehicle>();
        List<Inventory> inventories = new List<Inventory>();
        public AutomobileRepairShop()
        {
            InitializeComponent();
            this.Text = "Automobile Repair Shop";

            panelEmployee.BringToFront();

            // initializing the context
            context = new AutomobileRepairShopEntities();

            this.Load += AutomobileRepairShopMainForm_Load;

            MessageBox.Show("Hello, the way our application works is by using the four gridviews in the upper section of Employee Panel to create " +
                "a new service for the selected Client, by the selected Employee, with the selected Vehicle and the selected Part.  It is possible " +
                "to insert new Vehicles and Parts directly from the GridViews (vehicles & parts), but for Clients and Employees please use Data Entries " +
                "menu to insert the new entries.  Database Management has Import and Export, the Export function of this program works, you can see " +
                "the xml file created with all data from database, then you can use the import function to load xml into database. The Management panel has useful " +
                "functions like searching Services by Workshop Location, or by specific dates.  It is also possible to produce an annual report here");
        }

        // this method is create and add new Services into database by employee selected data in the employee panel.
        public void NewService()
        {
            // grab all currently selected objects
            Client client = (Client)dataGridViewClients.CurrentRow.DataBoundItem;
            Vehicle vehicle = (Vehicle)dataGridViewVehicles.CurrentRow.DataBoundItem;
            Employee employee = (Employee)dataGridViewEmployeeInClient.CurrentRow.DataBoundItem;
            Inventory part = (Inventory)dataGridViewParts.CurrentRow.DataBoundItem;

            DateTime date = DateTime.Now;

            // if charge cost set then continue
            if (textBoxServiceCharge.Text.ToString() != "")
            {
                Service newService =
                new Service
                {
                    Client = clients.Find(person => person.ClientId == client.ClientId),
                    ClientId = 1,
                    Employee = employees.Find(person => person.EmployeeId == employee.EmployeeId),
                    EmployeeId = 1,
                    Vehicle = vehicles.Find(car => car.VehicleId == vehicle.VehicleId),
                    VehicleId = 1,
                    Inventory = inventories.Find(item => item.PartId == part.PartId),
                    PartId = 1,
                    ServiceCost = Decimal.Parse(textBoxServiceCharge.Text),
                    ServiceLocation = listBoxServiceLocation.Text.ToString(),
                    ServiceStartDate = date
                };

                context.Services.Add(newService);

                SaveChangesToDB();

            }
            else
            {
                MessageBox.Show("Please input Service Charge");
            }
        }
        // method for creating new clients and adding them to database.
        public void NewClient()
        {

            string fName, lName, phone, address;

            fName = textBoxClientFName.Text.ToString();
            lName = textBoxClientLName.Text.ToString();
            phone = textBoxClientPhone.Text.ToString();
            address = textBoxClientAddress.Text.ToString();

            if (!textBoxClientAddress.Text.ToString().Equals("") ||
                !textBoxClientPhone.Text.ToString().Equals("") ||
                !textBoxClientFName.Text.ToString().Equals("") ||
                !textBoxClientLName.Text.ToString().Equals(""))
            {

                Client newClient = new Client { ClientFName = fName, ClientLName = lName, ClientAddress = address, ClientPhone = phone };

                context.Clients.Add(newClient);

                SaveChangesToDB();
            }
            else
                MessageBox.Show("Please fill data");
        }
        // method for creating new employees and adding them to database.
        public void NewEmployee()
        {

            string fName, lName, phone, address;

            fName = textBoxEmpFName.Text.ToString();
            lName = textBoxEmpLName.Text.ToString();
            phone = textBoxEmpPhone.Text.ToString();
            address = textBoxEmpAddress.Text.ToString();

            if (!textBoxEmpAddress.Text.ToString().Equals("") ||
              !textBoxEmpPhone.Text.ToString().Equals("") ||
              !textBoxEmpFName.Text.ToString().Equals("") ||
              !textBoxEmpLName.Text.ToString().Equals(""))
            {

                Employee newEmployee = new Employee { EmployeeFName = fName, EmployeeLName = lName, EmployeeAddress = address, EmployeePhone = phone };

                context.Employees.Add(newEmployee);

                SaveChangesToDB();
            }
            else
                MessageBox.Show("Please fill data");
        }
        // WORKING method to export current database to an xml file.
        private void exportSaveDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog
            {
                InitialDirectory = Path.GetFullPath(Application.StartupPath + "\\..\\.."),
            };
            // set a default file name
            savefile.FileName = "DatabaseBackUp.xml";
            // set filters
            savefile.Filter = "Xml files (*.xml)|*.xml|All files (*.*)|*.*";

            if (savefile.ShowDialog() == DialogResult.OK)
            {

                List<Client> clientList = context.Clients.ToList();
                List<Employee> emList = context.Employees.ToList();
                List<Vehicle> vehicleList = context.Vehicles.ToList();
                List<Inventory> partList = context.Inventories.ToList();
                List<Service> serviceList = context.Services.ToList();

                var xEle = new XElement("DbBackup",
                from client in clientList
                select new XElement("Client",
                    new XElement("ClientId", client.ClientId),
                    new XElement("ClientFName", client.ClientFName),
                    new XElement("ClientLName", client.ClientLName),
                    new XElement("ClientAddress", client.ClientAddress),
                    new XElement("ClientPhone", client.ClientPhone)
                    ),

                     from employee in emList
                     select new XElement("Employee",
                         new XElement("EmployeeId", employee.EmployeeId),
                         new XElement("EmployeeFName", employee.EmployeeFName),
                         new XElement("EmployeeLName", employee.EmployeeLName),
                         new XElement("EmployeeAddress", employee.EmployeeAddress),
                         new XElement("EmployeePhone", employee.EmployeePhone)
                         ),

                    from vehicle in vehicleList
                    select new XElement("Vehicle",
                        new XElement("VehicleId", vehicle.VehicleId),
                        new XElement("VehicleMake", vehicle.VehicleMake),
                        new XElement("VehicleModel", vehicle.VehicleModel),
                        new XElement("VehiclePlateNumber", vehicle.VehiclePlateNumber),
                        new XElement("VehicleStatus", vehicle.VehicleStatus)
                        ),

                    from part in partList
                    select new XElement("Inventory",
                        new XElement("PartId", part.PartId),
                        new XElement("PartName", part.PartName)
                        ),

                    from service in serviceList
                    select new XElement("Service",
                        new XElement("ServiceId", service.ServiceId),
                        new XElement("ClientId", service.ClientId),
                        new XElement("EmployeeId", service.EmployeeId),
                        new XElement("VehicleId", service.VehicleId),
                        new XElement("PartId", service.VehicleId),
                        new XElement("ServiceCost", service.ServiceCost),
                        new XElement("ServiceLocation", service.ServiceLocation),
                        new XElement("ServiceStartDate", service.ServiceStartDate),
                        new XElement("ServiceEndDate", service.ServiceEndDate)
                  //      new XElement("Client", service.Client),
                   //     new XElement("Employee", service.Employee),
                   //     new XElement("Vehicle", service.Vehicle),
                   //     new XElement("Inventory", service.Inventory)
                        )
                        );

                File.WriteAllText(savefile.FileName, xEle.ToString());
            }


        }
        // WORKING method to import xml file into database
        private void importLoadDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog
            {
                InitialDirectory = Path.GetFullPath(Application.StartupPath + "\\..\\.."),
            };
            openfile.Filter = "Xml files (*.xml)|*.xml|All files (*.*)|*.*";

            if (openfile.ShowDialog() == DialogResult.OK)

            {
                XDocument xDoc = XDocument.Load(openfile.FileName);
                //  XDocument test = XDocument.L

                List<Client> clientList = xDoc.Descendants("Client").Select(d =>
                    new Client
                    {
                        ClientId = int.Parse(d.Element("ClientId").Value),
                        ClientFName = d.Element("ClientFName").Value,
                        ClientLName = d.Element("ClientLName").Value,
                        ClientAddress = d.Element("ClientAddress").Value,
                        ClientPhone = d.Element("ClientPhone").Value
                    }).ToList();


                foreach (var i in clientList)
                {
                    var v = context.Clients.Where(a => a.ClientId.Equals(i.ClientId)).FirstOrDefault();
                    if (v != null)
                    {
                        v.ClientFName = i.ClientFName;
                        v.ClientLName = i.ClientLName;
                        v.ClientAddress = i.ClientAddress;
                        v.ClientPhone = i.ClientPhone;
                    }
                    else
                    {
                        context.Clients.Add(i);
                    }
                }

                SaveChangesToDB();

                List<Employee> employeeList = xDoc.Descendants("Employee").Select(d =>
                    new Employee
                    {
                        EmployeeId = int.Parse(d.Element("EmployeeId").Value),
                        EmployeeFName = d.Element("EmployeeFName").Value,
                        EmployeeLName = d.Element("EmployeeLName").Value,
                        EmployeeAddress = d.Element("EmployeeAddress").Value,
                        EmployeePhone = d.Element("EmployeePhone").Value
                    }).ToList();


                foreach (var i in employeeList)
                {
                    var v = context.Employees.Where(a => a.EmployeeId.Equals(i.EmployeeId)).FirstOrDefault();
                    if (v != null)
                    {
                        v.EmployeeFName = i.EmployeeFName;
                        v.EmployeeLName = i.EmployeeLName;
                        v.EmployeeAddress = i.EmployeeAddress;
                        v.EmployeePhone = i.EmployeePhone;
                    }
                    else
                    {
                        context.Employees.Add(i);
                    }
                }

                SaveChangesToDB();

                List<Vehicle> vehicleList = xDoc.Descendants("Vehicle").Select(d =>
                   new Vehicle
                   {
                       VehicleId = int.Parse(d.Element("VehicleId").Value),
                       VehicleMake = d.Element("VehicleMake").Value,
                       VehicleModel = d.Element("VehicleModel").Value,
                       VehiclePlateNumber = d.Element("VehiclePlateNumber").Value,
                       VehicleStatus = d.Element("VehicleStatus").Value
                   }).ToList();


                foreach (var i in vehicleList)
                {
                    var v = context.Vehicles.Where(a => a.VehicleId.Equals(i.VehicleId)).FirstOrDefault();
                    if (v != null)
                    {
                        v.VehicleMake = i.VehicleMake;
                        v.VehicleModel = i.VehicleModel;
                        v.VehiclePlateNumber = i.VehiclePlateNumber;
                        v.VehicleStatus = i.VehicleStatus;
                    }
                    else
                    {
                        context.Vehicles.Add(i);
                    }
                }

                SaveChangesToDB();

                List<Inventory> partList = xDoc.Descendants("Inventory").Select(d =>
                   new Inventory
                   {
                       PartId = int.Parse(d.Element("PartId").Value),
                       PartName = d.Element("PartName").Value

                   }).ToList();


                foreach (var i in partList)
                {
                    var v = context.Inventories.Where(a => a.PartId.Equals(i.PartId)).FirstOrDefault();
                    if (v != null)
                    {
                        v.PartName = i.PartName;
                    }
                    else
                    {
                        context.Inventories.Add(i);
                    }
                }

                SaveChangesToDB();

                List<Service> serviceList = xDoc.Descendants("Service").Select(d =>
                   new Service
                   {
                       ServiceId = int.Parse(d.Element("ServiceId").Value),
                       ClientId = int.Parse(d.Element("ClientId").Value),
                       EmployeeId = int.Parse(d.Element("EmployeeId").Value),
                       VehicleId = int.Parse(d.Element("VehicleId").Value),
                       PartId = int.Parse(d.Element("PartId").Value),
                       ServiceCost = decimal.Parse(d.Element("ServiceCost").Value),
                       ServiceLocation = d.Element("ServiceLocation").Value,
                       ServiceStartDate = DateTime.Parse(d.Element("ServiceStartDate").Value),
                       ServiceEndDate = string.IsNullOrEmpty(d.Element("ServiceEndDate").Value)
            ? (DateTime?)null
            : DateTime.Parse(d.Element("ServiceEndDate").Value),

                       Client = clients.Find(person => person.ClientId == int.Parse(d.Element("ClientId").Value)),
                       Employee = employees.Find(person => person.EmployeeId == int.Parse(d.Element("EmployeeId").Value)),
                       Vehicle = vehicleList.Find(car => car.VehicleId == int.Parse(d.Element("VehicleId").Value)),
                       Inventory = inventories.Find(item => item.PartId == int.Parse(d.Element("PartId").Value))

                   }).ToList();

                foreach (var i in serviceList)
                {
                    var v = context.Services.Where(a => a.ServiceId.Equals(i.ServiceId)).FirstOrDefault();
                    if (v != null)
                    {
                        v.ServiceId = i.ServiceId;
                        v.ClientId = i.ClientId;
                        v.EmployeeId = i.EmployeeId;
                        v.VehicleId = i.VehicleId;
                        v.PartId = i.PartId;
                        v.ServiceCost = i.ServiceCost;
                        v.ServiceLocation = i.ServiceLocation;
                        v.ServiceStartDate = i.ServiceStartDate;
                        v.ServiceEndDate = i.ServiceEndDate;
                    }
                    else
                    {
                        context.Services.Add(i);
                    }
                }

                SaveChangesToDB();
            }

        }
        // for testing purposes, and also when importing new xml file, good to wipe previous objects
        private void WipeDatabase()
        {
            context.Clients.Local.Clear();
            context.Employees.Local.Clear();
            context.Vehicles.Local.Clear();
            context.Inventories.Local.Clear();
            context.Services.Local.Clear();
            context.ServiceOrders.Local.Clear();
            context.SaveChanges();

            context.Database.ExecuteSqlCommand($"DBCC CHECKIDENT('Clients', RESEED, 0)");
            context.Database.ExecuteSqlCommand($"DBCC CHECKIDENT('Employees', RESEED, 0)");
            context.Database.ExecuteSqlCommand($"DBCC CHECKIDENT('Vehicles', RESEED, 0)");
            context.Database.ExecuteSqlCommand($"DBCC CHECKIDENT('Inventories', RESEED, 0)");
            context.Database.ExecuteSqlCommand($"DBCC CHECKIDENT('Service', RESEED, 0)");
            context.Database.ExecuteSqlCommand($"DBCC CHECKIDENT('ServiceOrder', RESEED, 0)");

            dataGridViewVehicles.Refresh();
            dataGridViewServicesManager.Refresh();
            dataGridViewClients.Refresh();
            dataGridViewEmployeeInClient.Refresh();
            dataGridViewParts.Refresh();
            dataGridViewServices.Refresh();

            SaveChangesToDB();
        }

        // this method is used to set the END date and vehicle status of currenctly selected Service
        public void EndSelectedService()
        {
            Service selectedService = (Service)dataGridViewServices.CurrentRow.DataBoundItem;

            DateTime date = DateTime.Now;

            var service = orders.Find(s => s.ServiceId == selectedService.ServiceId);

            selectedService.ServiceEndDate = date;
            selectedService.Vehicle.VehicleStatus = "Finished";

            SaveChangesToDB();

        }
        // method to save all changes to database.
        private void SaveChangesToDB()
        {
            try
            {
                context.SaveChanges();
            }

            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                foreach (var eve in ex.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                MessageBox.Show("Error inserting new Data");
                throw;

            }

            dataGridViewVehicles.Refresh();
            dataGridViewServicesManager.Refresh();
            dataGridViewClients.Refresh();
            dataGridViewEmployeeInClient.Refresh();
            dataGridViewParts.Refresh();
            dataGridViewServices.Refresh();

        }
        // main method that initializes all the gridviews, listboxes, and lists
        private void AutomobileRepairShopMainForm_Load(object sender, EventArgs e)
        {

            listBoxServiceLocation.SelectedIndex = 0;
            listBoxManagerLocation.SelectedIndex = 0;

            context.Database.Log = (s => Debug.Write(s));

            context.Clients.Load();
            context.Employees.Load();
            context.Vehicles.Load();
            context.Inventories.Load();
            context.Services.Load();
            context.ServiceOrders.Load();

            context.Database.ExecuteSqlCommand($"DBCC CHECKIDENT('Clients', RESEED, 0)");
            context.Database.ExecuteSqlCommand($"DBCC CHECKIDENT('Employees', RESEED, 0)");
            context.Database.ExecuteSqlCommand($"DBCC CHECKIDENT('Vehicles', RESEED, 0)");
            context.Database.ExecuteSqlCommand($"DBCC CHECKIDENT('Inventories', RESEED, 0)");
            context.Database.ExecuteSqlCommand($"DBCC CHECKIDENT('Service', RESEED, 0)");
            context.Database.ExecuteSqlCommand($"DBCC CHECKIDENT('ServiceOrder', RESEED, 0)");

            context.Clients.Local.Clear();
            context.Employees.Local.Clear();
            context.Vehicles.Local.Clear();
            context.Inventories.Local.Clear();
            context.Services.Local.Clear();
            context.ServiceOrders.Local.Clear();
            context.SaveChanges();

            // set datasource after created EF classes

            dataGridViewClients.DataSource = context.Clients.Local.ToBindingList();
            dataGridViewClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewClients.Columns["ClientId"].ReadOnly = false;
            dataGridViewClients.Columns["ClientFName"].Visible = true;
            dataGridViewClients.Columns["ClientLName"].Visible = true;
            dataGridViewClients.Columns["ClientAddress"].Visible = false;
            dataGridViewClients.Columns["ClientPhone"].Visible = false;
            dataGridViewClients.AllowUserToAddRows = false;
            dataGridViewClients.AllowUserToDeleteRows = false;

            dataGridViewVehicles.DataSource = context.Vehicles.Local.ToBindingList();
            dataGridViewVehicles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewVehicles.Columns["VehicleId"].ReadOnly = true;
            dataGridViewVehicles.Columns["VehicleMake"].Visible = true;
            dataGridViewVehicles.Columns["VehicleModel"].Visible = true;
            dataGridViewVehicles.Columns["VehiclePlateNumber"].Visible = true;
            dataGridViewVehicles.Columns["VehicleStatus"].Visible = true;
            dataGridViewVehicles.AllowUserToAddRows = true;
            dataGridViewVehicles.AllowUserToDeleteRows = false;

            dataGridViewParts.DataSource = context.Inventories.Local.ToBindingList();
            dataGridViewParts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewParts.Columns["PartId"].ReadOnly = true;
            dataGridViewParts.Columns["PartName"].Visible = true;
            dataGridViewParts.AllowUserToAddRows = true;
            dataGridViewParts.AllowUserToDeleteRows = false;


            dataGridViewServicesManager.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridViewEmployeeInClient.DataSource = context.Employees.Local.ToBindingList();
            dataGridViewEmployeeInClient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewEmployeeInClient.Columns["EmployeeId"].ReadOnly = true;
            dataGridViewEmployeeInClient.Columns["EmployeeFName"].Visible = true;
            dataGridViewEmployeeInClient.Columns["EmployeeLName"].Visible = true;
            dataGridViewEmployeeInClient.Columns["EmployeeAddress"].Visible = false;
            dataGridViewEmployeeInClient.Columns["EmployeePhone"].Visible = false;
            dataGridViewEmployeeInClient.AllowUserToAddRows = false;
            dataGridViewEmployeeInClient.AllowUserToDeleteRows = false;



            dataGridViewServices.DataSource = context.Services.Local.ToBindingList();
            dataGridViewServices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewServices.Columns["ServiceId"].ReadOnly = true;
            dataGridViewServices.Columns["ClientId"].Visible = true;
            dataGridViewServices.Columns["VehicleId"].Visible = true;
            dataGridViewServices.Columns["EmployeeId"].Visible = true;
            dataGridViewServices.Columns["PartId"].Visible = true;
            dataGridViewServices.Columns["ServiceStartDate"].Visible = true;
            dataGridViewServices.Columns["ServiceEndDate"].Visible = true;
            dataGridViewServices.Columns["ServiceCost"].Visible = true;
            dataGridViewServices.Columns["Client"].Visible = false;
            dataGridViewServices.Columns["Employee"].Visible = false;
            dataGridViewServices.Columns["Inventory"].Visible = false;
            dataGridViewServices.Columns["Vehicle"].Visible = false;
            dataGridViewServices.AllowUserToAddRows = false;
            dataGridViewServices.AllowUserToDeleteRows = false;

            // setting all starting database values for all tables
            clients.Clear();

            clients = new List<Client>() {
                new Client { ClientFName = "Max", ClientLName = "Peirano", ClientAddress = "Aberdeen Street", ClientPhone = "778-789-1695" },
                new Client { ClientFName = "Bruno", ClientLName = "Rissoto", ClientAddress = "East Woodstock Avenue", ClientPhone = "111-222-3333" },
                new Client { ClientFName = "Barbara", ClientLName = "Tethers", ClientAddress = "Arbor Avenue", ClientPhone = "222-111-1212" },
                new Client { ClientFName = "Nathan", ClientLName = "Campbell", ClientAddress = "Aberdeen Street", ClientPhone = "545-454-4545" },
                new Client { ClientFName = "Dominic", ClientLName = "Quang", ClientAddress = "Arbor Avenue", ClientPhone = "878-787-7878" },
            };

            context.Clients.AddRange(clients);

            employees.Clear();

            employees = new List<Employee>() {
                new Employee { EmployeeId = 1, EmployeeFName = "Elana", EmployeeLName = "Lobb", EmployeeAddress = "4033 Robson St", EmployeePhone = "778-789-1695" },
                new Employee { EmployeeId = 2, EmployeeFName = "Tobias", EmployeeLName = "Rand", EmployeeAddress = "Balfour Avenue", EmployeePhone = "778-789-1695" },
                new Employee { EmployeeId = 3, EmployeeFName = "Valene", EmployeeLName = "Israel", EmployeeAddress = "Alder Crossing", EmployeePhone = "778-789-1695" },
                new Employee { EmployeeId = 4, EmployeeFName = "Siu", EmployeeLName = "Haye", EmployeeAddress = "Cordiale Drive", EmployeePhone = "778-789-1695" },
                new Employee { EmployeeId = 5, EmployeeFName = "Lorri", EmployeeLName = "Toal", EmployeeAddress = "East 3rd Avenue", EmployeePhone = "778-789-1695" },
            };

            context.Employees.AddRange(employees);


            vehicles.Clear();

            vehicles = new List<Vehicle>() {
              new Vehicle { VehicleId = 1, VehicleMake = "Ford", VehicleModel = "Aeroster V6", VehiclePlateNumber = "R31176", VehicleStatus = "Finished" },
              new Vehicle { VehicleId = 2, VehicleMake = "Chevrolet", VehicleModel = "Corvette", VehiclePlateNumber = "WAUFC0", VehicleStatus = "Finished" },
              new Vehicle { VehicleId = 3, VehicleMake = "Honda", VehicleModel = "Civic", VehiclePlateNumber = "YV1LS5", VehicleStatus = "Started" },
              new Vehicle { VehicleId = 4, VehicleMake = "Toyota", VehicleModel = "Scion", VehiclePlateNumber = "5HD111", VehicleStatus = "Finished" },
              new Vehicle { VehicleId = 5, VehicleMake = "Dodge", VehicleModel = "Viper", VehiclePlateNumber = "3FEKF3", VehicleStatus = "Started" },
           };

            context.Vehicles.AddRange(vehicles);

            inventories = new List<Inventory>() {
              new Inventory { PartId = 1, PartName = "Radio" },
              new Inventory { PartId = 2, PartName = "Tire" },
              new Inventory { PartId = 3, PartName = "Break" },
              new Inventory { PartId = 4, PartName = "Headlights" },
              new Inventory { PartId = 5, PartName = "Alternators" },
              new Inventory { PartId = 6, PartName = "Rotor and Pad" },
              new Inventory { PartId = 7, PartName = "Air Filter" },
              new Inventory { PartId = 8, PartName = "Bodykit" },
              new Inventory { PartId = 9, PartName = "Carburetor" },
              new Inventory { PartId = 10, PartName = "Belt" },
              new Inventory { PartId = 11, PartName = "Mirror" },

           };

            context.Inventories.AddRange(inventories);

            DateTime date = DateTime.Now;

            orders = new List<Service> {

                new Service
               {
                ClientId = 1,
                EmployeeId = 1,
                VehicleId = 1,
                PartId = 1,
                ServiceCost = 50.99m,
                ServiceLocation = "New Westminster",
                ServiceStartDate = DateTime.Parse("2017-03-11 6:09 PM"),
                ServiceEndDate = DateTime.Parse("2017-03-13 4:09 PM"),
                Client = clients[0],
                Employee = employees[0],
                Vehicle = vehicles[0],
                Inventory = inventories[0]
               },

                new Service
               {
                ClientId = 2,
                EmployeeId = 2,
                VehicleId = 2,
                PartId = 2,
                ServiceCost = 78.99m,
                ServiceLocation = "Coquitlam",
                ServiceStartDate = DateTime.Parse("2017-03-14 5:09 PM"),
                ServiceEndDate = DateTime.Parse("2017-03-15 2:09 PM"),
                Client = clients[1],
                Employee = employees[1],
                Vehicle = vehicles[1],
                Inventory = inventories[1]
               },

               new Service
               {
                ClientId = 3,
                EmployeeId = 3,
                VehicleId = 3,
                PartId = 3,
                ServiceCost = 33.99m,
                ServiceLocation = "Coquitlam",
                ServiceStartDate = DateTime.Parse("2018-04-10 3:09 PM"),
                Client = clients[2],
                Employee = employees[2],
                Vehicle = vehicles[2],
                Inventory = inventories[2]
               },

               new Service
               {
                ClientId = 4,
                EmployeeId = 4,
                VehicleId = 4,
                PartId = 4,
                ServiceCost = 150.87m,
                ServiceLocation = "New Westminster",
                ServiceStartDate = DateTime.Parse("2018-03-17 2:30 PM"),
                ServiceEndDate = DateTime.Parse("2018-03-19 4:29 PM"),
                Client = clients[3],
                Employee = employees[3],
                Vehicle = vehicles[3],
                Inventory = inventories[3]
               },

               new Service
               {
                ClientId = 5,
                EmployeeId = 5,
                VehicleId = 5,
                PartId = 5,
                ServiceCost = 129.99m,
                ServiceLocation = "Coquitlam",
                ServiceStartDate = DateTime.Parse("2018-03-21 2:29 PM"),
                ServiceEndDate = DateTime.Parse("2018-03-22 5:29 PM"),
                Client = clients[4],
                Employee = employees[4],
                Vehicle = vehicles[4],
                Inventory = inventories[4]
               },

               new Service
               {
                ClientId = 1,
                EmployeeId = 1,
                VehicleId = 1,
                PartId = 6,
                ServiceCost = 200.69m,
                ServiceLocation = "New Westminster",
                ServiceStartDate = DateTime.Parse("2018-04-11 3:29 PM"),
                Client = clients[0],
                Employee = employees[0],
                Vehicle = vehicles[0],
                Inventory = inventories[0]
               },


            };

            context.Services.AddRange(orders);

            SaveChangesToDB();

        }
        // this method is called to generate the annual report for manager(s) in manager panel.
        private void GenerateAnnualReport()
        {

            var query3 = from service in context.Services
                         group service by service.ServiceStartDate.Year into s
                         select new AnnualReport()
                         {
                             Year = s.Key,
                             ServiceCount = s.Count(),
                             ServiceChargeSum = s.Sum(q => q.ServiceCost)
                         };

            dataGridViewReport.DataSource = query3.ToList();

        }

        // this method is called for managers to find all services available by store / workshop location
        private void FindServicesByStore()
        {
            dataGridViewServicesManager.Refresh();

            var query = context.Services.Where(s => s.ServiceLocation.Equals(listBoxManagerLocation.Text.ToString()));

            dataGridViewServicesManager.AllowUserToDeleteRows = false;
            dataGridViewServicesManager.AllowUserToAddRows = false;

            dataGridViewServicesManager.DataSource = query.ToList();
            dataGridViewServicesManager.Columns[9].Visible = false;
            dataGridViewServicesManager.Columns[10].Visible = false;
            dataGridViewServicesManager.Columns[11].Visible = false;
            dataGridViewServicesManager.Columns[12].Visible = false;
            dataGridViewServicesManager.Columns[2].Visible = false;
            dataGridViewServicesManager.Columns[3].Visible = false;
            dataGridViewServicesManager.Columns[4].Visible = false;
            dataGridViewServicesManager.Columns[1].Visible = false;
        }
        // this method is called for managers to find all services available by dates selected
        private void FindServicesByDates()
        {
            DateTime startDate = dateTimePickerStart.Value;
            DateTime endDate = dateTimePickerEnd.Value;

            dataGridViewServicesManager.Refresh();

            var query = context.Services.Where(s => s.ServiceStartDate >= startDate && s.ServiceStartDate <= endDate);

            dataGridViewServicesManager.AllowUserToDeleteRows = false;
            dataGridViewServicesManager.AllowUserToAddRows = false;

            dataGridViewServicesManager.DataSource = query.ToList();
            dataGridViewServicesManager.Columns[9].Visible = false;
            dataGridViewServicesManager.Columns[10].Visible = false;
            dataGridViewServicesManager.Columns[11].Visible = false;
            dataGridViewServicesManager.Columns[12].Visible = false;
            dataGridViewServicesManager.Columns[2].Visible = false;
            dataGridViewServicesManager.Columns[3].Visible = false;
            dataGridViewServicesManager.Columns[4].Visible = false;
            dataGridViewServicesManager.Columns[1].Visible = false;

        }

        // event handlers for switching between panels, etc.
        private void managerPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelManager.BringToFront();
        }

        private void employeePanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelEmployee.BringToFront();
        }

        private void newClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelNewClient.BringToFront();
        }

        private void newEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelNewEmployee.BringToFront();
        }

        private void newServiceOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelNewOrder.BringToFront();
        }

        private void buttonNewClient_Click(object sender, EventArgs e)
        {
            NewClient();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewService();
        }

        private void btnEndOrder_Click(object sender, EventArgs e)
        {
            EndSelectedService();
        }

        private void btnUpdateChanges_Click(object sender, EventArgs e)
        {
            SaveChangesToDB();
        }
        private void btnNukeDB_Click(object sender, EventArgs e)
        {
            WipeDatabase();
        }

        private void btnFindServicesByDate_Click(object sender, EventArgs e)
        {
            FindServicesByDates();
        }

        private void btnServicesByStore_Click(object sender, EventArgs e)
        {
            FindServicesByStore();
        }

        private void btnClearServicesByDate_Click(object sender, EventArgs e)
        {
            dataGridViewServicesManager.DataSource = null;
        }

        private void btnMakeAnualReport_Click(object sender, EventArgs e)
        {
            GenerateAnnualReport();
        }

        private void btnClearAnualReport_Click(object sender, EventArgs e)
        {
            dataGridViewReport.DataSource = null;
        }
        private void btnInsertNewEmployee_Click(object sender, EventArgs e)
        {
            NewEmployee();
        }

    }
    // custom class for annual reports
    internal class AnnualReport
    {
        public AnnualReport()
        {
        }

        [DisplayName("Year")]
        public int Year { get; set; }

        [DisplayName("Number of Services")]
        public decimal ServiceCount { get; set; }

        [DisplayName("Total Revenue")]
        public decimal ServiceChargeSum { get; set; }
    }
}
