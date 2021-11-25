using Opc.Ua;
using Opc.Ua.Client;
using Opc.Ua.Client.Controls;
using Opc.Ua.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestConnectOPCUA
{
    public partial class Form1 : Form
    {
        int floor = 0;
        int FirstInclude = 0;
        int cnt_floor = 0;
        string _check = "+";
        string _status = "+";
        bool check = false;

        public Form1()
        {
            InitializeComponent();

        }
        private Session m_session;
        private bool m_connectedOnce;
        private Subscription m_subscription;

        private void connectServerCtrl1_ConnectComplete(object sender, EventArgs e)
        {
          
                try
                {
                    m_session = connectServerCtrl1.Session;

                    
                    if (m_session != null && !m_connectedOnce)
                    {
                        m_connectedOnce = true;
                        pb_lift.Visible = true;
                        //connected
                        CreateSubscriptionAndMonitorItem();
                    }


                }
                catch (Exception exception)
                {
                    ClientUtils.HandleException(this.Text, exception);
                }
            
        }//Подключение к OPC

        private void CreateSubscriptionAndMonitorItem()
        {
            try
            {
                if (m_session == null)
                {
                    return;
                }

                if (m_subscription != null)
                {
                    m_session.RemoveSubscription(m_subscription);
                    m_subscription = null;
                }

                m_subscription = new Subscription();
                m_subscription.PublishingEnabled = true;
                m_subscription.PublishingInterval = 1000;
                m_subscription.Priority = 1;
                m_subscription.KeepAliveCount = 10;
                m_subscription.LifetimeCount = 20;
                m_subscription.MaxNotificationsPerPublish = 1000;

                m_session.AddSubscription(m_subscription);
                m_subscription.Create();

                //Направление:

                MonitoredItem monitoredItem1 = new MonitoredItem();
                monitoredItem1.StartNodeId = new NodeId($"2.{tb_numberLB.Text}.406", 1);
                monitoredItem1.AttributeId = Attributes.Value;
                monitoredItem1.Notification += MonitoredItem1_Notification;
                m_subscription.AddItem(monitoredItem1);

                //Текущий этаж:
                this.tb_CurrentFloor.Text = "---";
                MonitoredItem monitoredItem2 = new MonitoredItem();
                monitoredItem2.StartNodeId = new NodeId($"2.{tb_numberLB.Text}.402", 1);
                monitoredItem2.AttributeId = Attributes.Value;
                monitoredItem2.Notification += MonitoredItem2_Notification;
                m_subscription.AddItem(monitoredItem2);

                //Вызовы с этажей:

                MonitoredItem monitoredItem3 = new MonitoredItem();
                monitoredItem3.StartNodeId = new NodeId($"2.{tb_numberLB.Text}.350.24", 1);
                monitoredItem3.AttributeId = Attributes.Value;
                monitoredItem3.Notification += MonitoredItem3_Notification;
                m_subscription.AddItem(monitoredItem3);

                //Общее кол-во этажей:

                MonitoredItem monitoredItem4 = new MonitoredItem();
                monitoredItem4.StartNodeId = new NodeId($"2.{tb_numberLB.Text}.403", 1);
                monitoredItem4.AttributeId = Attributes.Value;
                monitoredItem4.Notification += MonitoredItem4_Notification;
                m_subscription.AddItem(monitoredItem4);

                //Статус дверей:

                MonitoredItem monitoredItem5 = new MonitoredItem();
                monitoredItem5.StartNodeId = new NodeId($"2.{tb_numberLB.Text}.407", 1);
                monitoredItem5.AttributeId = Attributes.Value;
                monitoredItem5.Notification += MonitoredItem5_Notification;
                m_subscription.AddItem(monitoredItem5);

                //Чекбоксы

                //ВП:

                MonitoredItem monitoredItem6 = new MonitoredItem();
                monitoredItem6.StartNodeId = new NodeId($"2.{tb_numberLB.Text}.350.1", 1);
                monitoredItem6.AttributeId = Attributes.Value;
                monitoredItem6.Notification += MonitoredItem6_Notification;
                m_subscription.AddItem(monitoredItem6);

                //СТОП1:

                MonitoredItem monitoredItem7 = new MonitoredItem();
                monitoredItem7.StartNodeId = new NodeId($"2.{tb_numberLB.Text}.350.2", 1);
                monitoredItem7.AttributeId = Attributes.Value;
                monitoredItem7.Notification += MonitoredItem7_Notification;
                m_subscription.AddItem(monitoredItem7);

                //СТОП2:

                MonitoredItem monitoredItem8 = new MonitoredItem();
                monitoredItem8.StartNodeId = new NodeId($"2.{tb_numberLB.Text}.350.3", 1);
                monitoredItem8.AttributeId = Attributes.Value;
                monitoredItem8.Notification += MonitoredItem8_Notification;
                m_subscription.AddItem(monitoredItem8);

                //ДК1:

                MonitoredItem monitoredItem9 = new MonitoredItem();
                monitoredItem9.StartNodeId = new NodeId($"2.{tb_numberLB.Text}.350.4", 1);
                monitoredItem9.AttributeId = Attributes.Value;
                monitoredItem9.Notification += MonitoredItem9_Notification;
                m_subscription.AddItem(monitoredItem9);

                //ДК2:

                MonitoredItem monitoredItem10 = new MonitoredItem();
                monitoredItem10.StartNodeId = new NodeId($"2.{tb_numberLB.Text}.350.5", 1);
                monitoredItem10.AttributeId = Attributes.Value;
                monitoredItem10.Notification += MonitoredItem10_Notification;
                m_subscription.AddItem(monitoredItem10);

                //РКД:

                MonitoredItem monitoredItem11 = new MonitoredItem();
                monitoredItem11.StartNodeId = new NodeId($"2.{tb_numberLB.Text}.350.6", 1);
                monitoredItem11.AttributeId = Attributes.Value;
                monitoredItem11.Notification += MonitoredItem11_Notification;
                m_subscription.AddItem(monitoredItem11);

                //ДШ: 
                
                MonitoredItem monitoredItem12 = new MonitoredItem();
                monitoredItem12.StartNodeId = new NodeId($"2.{tb_numberLB.Text}.318", 1);
                monitoredItem12.AttributeId = Attributes.Value;
                monitoredItem12.Notification += MonitoredItem12_Notification;
                m_subscription.AddItem(monitoredItem12);
                
                //РД:

                MonitoredItem monitoredItem13 = new MonitoredItem();
                monitoredItem13.StartNodeId = new NodeId($"2.{tb_numberLB.Text}.350.28", 1);
                monitoredItem13.AttributeId = Attributes.Value;
                monitoredItem13.Notification += MonitoredItem13_Notification;
                m_subscription.AddItem(monitoredItem13);

                //УКСЛ:

                MonitoredItem monitoredItem14 = new MonitoredItem();
                monitoredItem14.StartNodeId = new NodeId($"2.{tb_numberLB.Text}.350.12", 1);
                monitoredItem14.AttributeId = Attributes.Value;
                monitoredItem14.Notification += MonitoredItem14_Notification;
                m_subscription.AddItem(monitoredItem14);

                //РОД:

                MonitoredItem monitoredItem15 = new MonitoredItem();
                monitoredItem15.StartNodeId = new NodeId($"2.{tb_numberLB.Text}.350.7", 1);
                monitoredItem15.AttributeId = Attributes.Value;
                monitoredItem15.Notification += MonitoredItem15_Notification;
                m_subscription.AddItem(monitoredItem15);

                //РЗД:

                MonitoredItem monitoredItem16 = new MonitoredItem();
                monitoredItem16.StartNodeId = new NodeId($"2.{tb_numberLB.Text}.350.8", 1);
                monitoredItem16.AttributeId = Attributes.Value;
                monitoredItem16.Notification += MonitoredItem16_Notification;
                m_subscription.AddItem(monitoredItem16);

                //ВЫЗОВ:

                MonitoredItem monitoredItem17 = new MonitoredItem();
                monitoredItem17.StartNodeId = new NodeId($"2.{tb_numberLB.Text}.350.11", 1);
                monitoredItem17.AttributeId = Attributes.Value;
                monitoredItem17.Notification += MonitoredItem17_Notification;
                m_subscription.AddItem(monitoredItem17);

                //АБЛ:

                MonitoredItem monitoredItem18 = new MonitoredItem();
                monitoredItem18.StartNodeId = new NodeId($"2.{tb_numberLB.Text}.350.9", 1);
                monitoredItem18.AttributeId = Attributes.Value;
                monitoredItem18.Notification += MonitoredItem18_Notification;
                m_subscription.AddItem(monitoredItem18);

                //МП:

                MonitoredItem monitoredItem19 = new MonitoredItem();
                monitoredItem19.StartNodeId = new NodeId($"2.{tb_numberLB.Text}.350.10", 1);
                monitoredItem19.AttributeId = Attributes.Value;
                monitoredItem19.Notification += MonitoredItem19_Notification;
                m_subscription.AddItem(monitoredItem19);

                //USER1:

                MonitoredItem monitoredItem20 = new MonitoredItem();
                monitoredItem20.StartNodeId = new NodeId($"2.{tb_numberLB.Text}.348.1", 1);
                monitoredItem20.AttributeId = Attributes.Value;
                monitoredItem20.Notification += MonitoredItem20_Notification;
                m_subscription.AddItem(monitoredItem20);

                //USER2:

                MonitoredItem monitoredItem21 = new MonitoredItem();
                monitoredItem21.StartNodeId = new NodeId($"2.{tb_numberLB.Text}.348.2", 1);
                monitoredItem21.AttributeId = Attributes.Value;
                monitoredItem21.Notification += MonitoredItem21_Notification;
                m_subscription.AddItem(monitoredItem21);

                //USER3:

                MonitoredItem monitoredItem22 = new MonitoredItem();
                monitoredItem22.StartNodeId = new NodeId($"2.{tb_numberLB.Text}.348.3", 1);
                monitoredItem22.AttributeId = Attributes.Value;
                monitoredItem22.Notification += MonitoredItem22_Notification;
                m_subscription.AddItem(monitoredItem22);

                //USER4:

                MonitoredItem monitoredItem23 = new MonitoredItem();
                monitoredItem23.StartNodeId = new NodeId($"2.{tb_numberLB.Text}.348.4", 1);
                monitoredItem23.AttributeId = Attributes.Value;
                monitoredItem23.Notification += MonitoredItem23_Notification;
                m_subscription.AddItem(monitoredItem23);

                //FIRE:

                MonitoredItem monitoredItem24 = new MonitoredItem();
                monitoredItem24.StartNodeId = new NodeId($"2.{tb_numberLB.Text}.327", 1);
                monitoredItem24.AttributeId = Attributes.Value;
                monitoredItem24.Notification += MonitoredItem24_Notification;
                m_subscription.AddItem(monitoredItem24);

                //15КГ:

                MonitoredItem monitoredItem25 = new MonitoredItem();
                monitoredItem25.StartNodeId = new NodeId($"2.{tb_numberLB.Text}.350.17", 1);
                monitoredItem25.AttributeId = Attributes.Value;
                monitoredItem25.Notification += MonitoredItem25_Notification;
                m_subscription.AddItem(monitoredItem25);
                /*
                //Зажата кнопка STOP:

                MonitoredItem monitoredItem26 = new MonitoredItem();
                monitoredItem26.StartNodeId = new NodeId($"2.{tb_numberLB.Text}.304", 1);
                monitoredItem26.AttributeId = Attributes.Value;
                monitoredItem26.Notification += MonitoredItem26_Notification;
                m_subscription.AddItem(monitoredItem26);
                */
                //Резервное питание:

                MonitoredItem monitoredItem27 = new MonitoredItem();
                monitoredItem27.StartNodeId = new NodeId($"2.{tb_numberLB.Text}.325", 1);
                monitoredItem27.AttributeId = Attributes.Value;
                monitoredItem27.Notification += MonitoredItem27_Notification;
                m_subscription.AddItem(monitoredItem27);

                //Нет связи с ЛБ:

                MonitoredItem monitoredItem28 = new MonitoredItem();
                monitoredItem28.StartNodeId = new NodeId($"2.{tb_numberLB.Text}.328", 1);
                monitoredItem28.AttributeId = Attributes.Value;
                monitoredItem28.Notification += MonitoredItem28_Notification;
                m_subscription.AddItem(monitoredItem28);

                //Панель приказов:

                MonitoredItem monitoredItem29 = new MonitoredItem();
                monitoredItem29.StartNodeId = new NodeId($"2.{tb_numberLB.Text}.350.25", 1);
                monitoredItem29.AttributeId = Attributes.Value;
                monitoredItem29.Notification += MonitoredItem29_Notification;
                m_subscription.AddItem(monitoredItem29);

                //Проникновение в шахту лифта или МП:

                MonitoredItem monitoredItem30 = new MonitoredItem();
                monitoredItem30.StartNodeId = new NodeId($"2.{tb_numberLB.Text}.312", 1);
                monitoredItem30.AttributeId = Attributes.Value;
                monitoredItem30.Notification += MonitoredItem30_Notification;
                m_subscription.AddItem(monitoredItem30);

                //Зажата кнопка СТОП:

                MonitoredItem monitoredItem31 = new MonitoredItem();
                monitoredItem31.StartNodeId = new NodeId($"2.{tb_numberLB.Text}.304", 1);
                monitoredItem31.AttributeId = Attributes.Value;
                monitoredItem31.Notification += MonitoredItem31_Notification;
                m_subscription.AddItem(monitoredItem31);

                //Кабина в открытом состоянии

                MonitoredItem monitoredItem32 = new MonitoredItem();
                monitoredItem32.StartNodeId = new NodeId($"2.{tb_numberLB.Text}.305", 1);
                monitoredItem32.AttributeId = Attributes.Value;
                monitoredItem32.Notification += MonitoredItem32_Notification;
                m_subscription.AddItem(monitoredItem32);

                //Отсутствует напряжение в цепи

                MonitoredItem monitoredItem33 = new MonitoredItem();
                monitoredItem33.StartNodeId = new NodeId($"2.{tb_numberLB.Text}.303", 1);
                monitoredItem33.AttributeId = Attributes.Value;
                monitoredItem33.Notification += MonitoredItem33_Notification;
                m_subscription.AddItem(monitoredItem33);



                m_subscription.ApplyChanges();
            }
            catch (Exception exception)
            {
                ClientUtils.HandleException(this.Text, exception);
            }
        }
        //Направление
        public void MonitoredItem1_Notification(MonitoredItem monitoredItem, MonitoredItemNotificationEventArgs e)
        {

            if (InvokeRequired)
            {
                BeginInvoke(new MonitoredItemNotificationEventHandler(MonitoredItem1_Notification), monitoredItem, e);
                return;
            }
            
            try
            {
                string trend = (((MonitoredItemNotification)e.NotificationValue).Value.WrappedValue.ToString());
                if (trend == "2")
                {
                    pb_trend.Image = Image.FromFile(@".\img\ARW02UP.png");

                }
                else if (trend == "3")
                {
                    pb_trend.Image = Image.FromFile(@".\img\ARW02DN.png");

                }
                else if (trend == "4")
                {
                    pb_trend.Image = Image.FromFile(@".\img\STOP.png");

                }
                else if (trend == "0")
                {
                    pb_trend.Image = null;
                }
            }
            catch (Exception ex)
            {
                ClientUtils.HandleException(this.Text, ex);
            }
        }
        //Текущий этаж
        private void MonitoredItem2_Notification(MonitoredItem monitoredItem, MonitoredItemNotificationEventArgs e)
        {

            if (InvokeRequired)
            {
                BeginInvoke(new MonitoredItemNotificationEventHandler(MonitoredItem2_Notification), monitoredItem, e);
                return;
            }
        
            try
            {
      
                if (FirstInclude == 0)
                {
                    pb_lift.Location = new Point(630, 430 - (40 * Convert.ToInt32(((MonitoredItemNotification)e.NotificationValue).Value.WrappedValue.ToString())));
                    FirstInclude++;
                }
                tb_CurrentFloor.Invoke((MethodInvoker)delegate
                {
                    tb_CurrentFloor.Text = ((MonitoredItemNotification)e.NotificationValue).Value.WrappedValue.ToString();
                });
            }
            catch (Exception ex)
            {
                ClientUtils.HandleException(this.Text, ex);
            }


        }
        //Вызовы с этажей
        private void MonitoredItem3_Notification(MonitoredItem monitoredItem, MonitoredItemNotificationEventArgs e)
        {

            if (InvokeRequired)
            {
                BeginInvoke(new MonitoredItemNotificationEventHandler(MonitoredItem3_Notification), monitoredItem, e);
                return;
            }
            
            int floor = 0;
            try
            {
                string floor_byteStr = ((MonitoredItemNotification)e.NotificationValue).Value.WrappedValue.ToString();
                int floor_byte = Convert.ToInt32(floor_byteStr);
                if (!floor_byte.Equals(0))
                {
                   
                    while (floor_byte != 1)
                    {
                        floor_byte = floor_byte / 2;
                        floor++;
                    }
                    floor++;
                    (Controls[$"lb_floor{floor}"] as Label).Invoke((MethodInvoker)delegate
                    {
                        (Controls[$"lb_floor{floor}"] as Label).BackColor = Color.Red;
                    });
                    myThread(430 - 40 * floor, pb_lift.Location.Y);
                }
                else
                {
                    for (int i = 1; i <= Convert.ToInt32(cnt_floor); i++)
                    {
                        (Controls[$"lb_floor{i}"] as Label).Invoke((MethodInvoker)delegate
                        {
                            (Controls[$"lb_floor{i}"] as Label).BackColor = Color.White;
                        });
                    }
                }
            }
            catch (Exception ex)
            {
               
            }
            
          
        }
        //Общее кол-во этажей
        private void MonitoredItem4_Notification(MonitoredItem monitoredItem, MonitoredItemNotificationEventArgs e)
        {
     
            if (InvokeRequired)
            {
                BeginInvoke(new MonitoredItemNotificationEventHandler(MonitoredItem4_Notification), monitoredItem, e);
                return;
            }
      
            try
            {
                this.tb_CntFloor.Text = ((MonitoredItemNotification)e.NotificationValue).Value.WrappedValue.ToString();
                cnt_floor = Convert.ToInt32(((MonitoredItemNotification)e.NotificationValue).Value.WrappedValue.ToString());

                for (int i = 1; i <= Convert.ToInt32(cnt_floor); i++)
                {

                    (this.Controls[$"lb_floor{i}"] as Label).Visible = true;
                }
                for (int i = 1; i <= Convert.ToInt32(cnt_floor); i++)
                {

                    (this.Controls[$"rb_floor{i}"] as RadioButton).Visible = true;
                }

            }
            catch (Exception ex)
            {
                ClientUtils.HandleException(this.Text, ex);
            }
        }
        //Статус дверей
        public void MonitoredItem5_Notification(MonitoredItem monitoredItem, MonitoredItemNotificationEventArgs e)
        {

            if (InvokeRequired)
            {
                BeginInvoke(new MonitoredItemNotificationEventHandler(MonitoredItem5_Notification), monitoredItem, e);
                return;
            }
      
            try
            {
                string status = (((MonitoredItemNotification)e.NotificationValue).Value.WrappedValue.ToString());
                PeopleInLift(null, status);
            }
            catch (Exception ex)
            {
                ClientUtils.HandleException(this.Text, ex);
            }
        }
        //ВП
        private void MonitoredItem6_Notification(MonitoredItem monitoredItem, MonitoredItemNotificationEventArgs e)
        {
    
            try
            {
                check = ((MonitoredItemNotification)e.NotificationValue).Value.ToString().Equals("True");
                this.cb_VP.Invoke((MethodInvoker)delegate
                {

                    this.cb_VP.Checked = check;
                });
            }
            catch (Exception ex)
            {
                ClientUtils.HandleException(this.Text, ex);
            }
        }
        //СТОП1
        private void MonitoredItem7_Notification(MonitoredItem monitoredItem, MonitoredItemNotificationEventArgs e)
        {
            try
            {
                check = ((MonitoredItemNotification)e.NotificationValue).Value.ToString().Equals("True");
                this.cb_STOP1.Invoke((MethodInvoker)delegate
                {

                    this.cb_STOP1.Checked = check;
                });

            }
            catch (Exception ex)
            {
                ClientUtils.HandleException(this.Text, ex);
            }
        }
        //СТОП2
        private void MonitoredItem8_Notification(MonitoredItem monitoredItem, MonitoredItemNotificationEventArgs e)
        {
            try
            {
                check = ((MonitoredItemNotification)e.NotificationValue).Value.ToString().Equals("True");
                this.cb_STOP2.Invoke((MethodInvoker)delegate
                {

                    this.cb_STOP2.Checked = check;
                });
            }
            catch (Exception ex)
            {
                ClientUtils.HandleException(this.Text, ex);
            }
        }
        //ДК1
        private void MonitoredItem9_Notification(MonitoredItem monitoredItem, MonitoredItemNotificationEventArgs e)
        {

            try
            {
                check = ((MonitoredItemNotification)e.NotificationValue).Value.ToString().Equals("True");
                this.cb_DK1.Invoke((MethodInvoker)delegate
                {

                    this.cb_DK1.Checked = check;
                });
            }
            catch (Exception ex)
            {
                ClientUtils.HandleException(this.Text, ex);
            }
        }
        //ДК2
        public void MonitoredItem10_Notification(MonitoredItem monitoredItem, MonitoredItemNotificationEventArgs e)
        {

            try
            {
                check = ((MonitoredItemNotification)e.NotificationValue).Value.ToString().Equals("True");
                this.cb_DK2.Invoke((MethodInvoker)delegate
                {

                    this.cb_DK2.Checked = check;
                });
            }
            catch (Exception ex)
            {
                ClientUtils.HandleException(this.Text, ex);
            }
        }
        //РКД
        private void MonitoredItem11_Notification(MonitoredItem monitoredItem, MonitoredItemNotificationEventArgs e)
        {
             

            try
            {
                check = ((MonitoredItemNotification)e.NotificationValue).Value.ToString().Equals("True");
                this.cb_RKD.Invoke((MethodInvoker)delegate
                {

                    this.cb_RKD.Checked = check;
                });
               
            }
            catch (Exception ex)
            {
                ClientUtils.HandleException(this.Text, ex);
            }
        }
        //(Отсутствует) ДШ 
        private void MonitoredItem12_Notification(MonitoredItem monitoredItem, MonitoredItemNotificationEventArgs e)
        {

            if (InvokeRequired)
            {
                BeginInvoke(new MonitoredItemNotificationEventHandler(MonitoredItem3_Notification), monitoredItem, e);
                return;
            }

            string floor = (((MonitoredItemNotification)e.NotificationValue).Value.WrappedValue.ToString());

            try
            {

            }
            catch (Exception ex)
            {
                ClientUtils.HandleException(this.Text, ex);
            }
        }
        //РД
        private void MonitoredItem13_Notification(MonitoredItem monitoredItem, MonitoredItemNotificationEventArgs e)
        {
    
            try
            {
                 check = ((MonitoredItemNotification)e.NotificationValue).Value.ToString().Equals("True");
                 this.cb_RD.Invoke((MethodInvoker)delegate
                 {

                     this.cb_RD.Checked = check;
                 });
            }
            catch (Exception ex)
            {
                ClientUtils.HandleException(this.Text, ex);
            }
        }
        //УКСП
        private void MonitoredItem14_Notification(MonitoredItem monitoredItem, MonitoredItemNotificationEventArgs e)
        {
             

            try
            {

                check = ((MonitoredItemNotification)e.NotificationValue).Value.ToString().Equals("True");
            }
            catch
            {

            }
           
            try
            {
                this.cb_UKSP.Invoke((MethodInvoker)delegate
                {

                    this.cb_UKSP.Checked = check;
                });
            }
            catch (Exception ex)
            {
                ClientUtils.HandleException(this.Text, ex);
            }
        }
        //РОД
        private void MonitoredItem15_Notification(MonitoredItem monitoredItem, MonitoredItemNotificationEventArgs e)
        {

             

            try
            {

                check = ((MonitoredItemNotification)e.NotificationValue).Value.ToString().Equals("True");
            }
            catch
            {

            }
           
            try
            {
                this.cb_ROD.Invoke((MethodInvoker)delegate
                {

                    this.cb_ROD.Checked = check;
                });
            }
            catch (Exception ex)
            {
                ClientUtils.HandleException(this.Text, ex);
            }
        }
        //РЗД
        private void MonitoredItem16_Notification(MonitoredItem monitoredItem, MonitoredItemNotificationEventArgs e)
        {

             

            try
            {

                check = ((MonitoredItemNotification)e.NotificationValue).Value.ToString().Equals("True");
            }
            catch
            {

            }
           
            try
            {
                this.cb_RZD.Invoke((MethodInvoker)delegate
                {

                    this.cb_RZD.Checked = check;
                });
            }
            catch (Exception ex)
            {
                ClientUtils.HandleException(this.Text, ex);
            }
        }
        //ВЫЗОВ
        public void MonitoredItem17_Notification(MonitoredItem monitoredItem, MonitoredItemNotificationEventArgs e)
        {

            try
            {
                 check = ((MonitoredItemNotification)e.NotificationValue).Value.ToString().Equals("True");
                this.cb_VIZOV.Invoke((MethodInvoker)delegate
                {

                this.cb_VIZOV.Checked = check;
                });
                this.pb_VIZOV.Invoke((MethodInvoker)delegate
                {

                    this.pb_VIZOV.Visible = check;
                });
            }
            catch (Exception ex)
            {
                ClientUtils.HandleException(this.Text, ex);
            }
        }
        //АБЛ
        private void MonitoredItem18_Notification(MonitoredItem monitoredItem, MonitoredItemNotificationEventArgs e)
        {
        
            try
            {
                check = ((MonitoredItemNotification)e.NotificationValue).Value.ToString().Equals("True");
                this.cb_ABL.Invoke((MethodInvoker)delegate
                {

                    this.cb_ABL.Checked = check;
                });
            }
            catch (Exception ex)
            {
                ClientUtils.HandleException(this.Text, ex);
            }
        }
        //МП
        private void MonitoredItem19_Notification(MonitoredItem monitoredItem, MonitoredItemNotificationEventArgs e)
        {
            try
            {
                check = ((MonitoredItemNotification)e.NotificationValue).Value.ToString().Equals("True");
                this.cb_MP.Invoke((MethodInvoker)delegate
                {

                    this.cb_MP.Checked = check;
                });
                this.pb_MP.Invoke((MethodInvoker)delegate
                {

                    this.pb_MP.Visible = check;
                });
            }
            catch (Exception ex)
            {
                ClientUtils.HandleException(this.Text, ex);
            }
        }
        //USER1
        private void MonitoredItem20_Notification(MonitoredItem monitoredItem, MonitoredItemNotificationEventArgs e)
        {
            try
            {
                check = ((MonitoredItemNotification)e.NotificationValue).Value.ToString().Equals("True");
                this.cb_User1.Invoke((MethodInvoker)delegate
                {

                    this.cb_User1.Checked = check;
                });
            }
            catch (Exception ex)
            {
                ClientUtils.HandleException(this.Text, ex);
            }
        }
        //USER2
        private void MonitoredItem21_Notification(MonitoredItem monitoredItem, MonitoredItemNotificationEventArgs e)
        {
            try
            {
                check = ((MonitoredItemNotification)e.NotificationValue).Value.ToString().Equals("True");
                this.cb_User2.Invoke((MethodInvoker)delegate
                {

                    this.cb_User2.Checked = check;
                });
            }
            catch (Exception ex)
            {
                ClientUtils.HandleException(this.Text, ex);
            }
        }
        //USER3
        private void MonitoredItem22_Notification(MonitoredItem monitoredItem, MonitoredItemNotificationEventArgs e)
        {
            try
            {
                check = ((MonitoredItemNotification)e.NotificationValue).Value.ToString().Equals("True");
                this.cb_User3.Invoke((MethodInvoker)delegate
                {

                    this.cb_User3.Checked = check;
                });
            }
            catch (Exception ex)
            {
                ClientUtils.HandleException(this.Text, ex);
            }
        }
        //USER4
        private void MonitoredItem23_Notification(MonitoredItem monitoredItem, MonitoredItemNotificationEventArgs e)
        {
            try
            {
                check = ((MonitoredItemNotification)e.NotificationValue).Value.ToString().Equals("True");
                this.cb_User4.Invoke((MethodInvoker)delegate
                {

                    this.cb_User4.Checked = check;
                });
            }
            catch (Exception ex)
            {
                ClientUtils.HandleException(this.Text, ex);
            }
        }
        //FIRE
        private void MonitoredItem24_Notification(MonitoredItem monitoredItem, MonitoredItemNotificationEventArgs e)
        {
            try
            {
                check = ((MonitoredItemNotification)e.NotificationValue).Value.ToString().Equals("True");
                this.pb_fire.Invoke((MethodInvoker)delegate
                {

                    this.pb_fire.Visible = check;
                });
            }
            catch (Exception ex)
            {
                ClientUtils.HandleException(this.Text, ex);
            }
        }
        //15 КГ
        private void MonitoredItem25_Notification(MonitoredItem monitoredItem, MonitoredItemNotificationEventArgs e)
        {
            string check ="";
            try
            {
                check = ((MonitoredItemNotification)e.NotificationValue).Value.ToString();
                PeopleInLift(check, null);
            }
            catch (Exception ex)
            {
                ClientUtils.HandleException(this.Text, ex);
            }
        }
        /*
        //Зажата кнопка STOP:
        private void MonitoredItem26_Notification(MonitoredItem monitoredItem, MonitoredItemNotificationEventArgs e)
        {
            try
            {
                check = ((MonitoredItemNotification)e.NotificationValue).Value.ToString().Equals("True");
                this.pb_STOP.Invoke((MethodInvoker)delegate
                {

                    this.pb_STOP.Visible = check;
                });
            }
            catch (Exception ex)
            {
                ClientUtils.HandleException(this.Text, ex);
            }
        }
        */
        //Резервное питание:
        private void MonitoredItem27_Notification(MonitoredItem monitoredItem, MonitoredItemNotificationEventArgs e)
        {
            try
            {
                check = ((MonitoredItemNotification)e.NotificationValue).Value.ToString().Equals("True");
                this.pb_PowerR.Invoke((MethodInvoker)delegate
                {

                    this.pb_PowerR.Visible = check;
                });
            }
            catch (Exception ex)
            {
                ClientUtils.HandleException(this.Text, ex);
            }
        }
        //Нет связи с ЛБ:
        private void MonitoredItem28_Notification(MonitoredItem monitoredItem, MonitoredItemNotificationEventArgs e)
        {
            try
            {
                check = ((MonitoredItemNotification)e.NotificationValue).Value.ToString().Equals("True");
                this.pb_NoNet.Invoke((MethodInvoker)delegate
                {

                    this.pb_NoNet.Visible = check;
                });
            }
            catch (Exception ex)
            {
                ClientUtils.HandleException(this.Text, ex);
            }
        }
        //Панель приказов:
        private void MonitoredItem29_Notification(MonitoredItem monitoredItem, MonitoredItemNotificationEventArgs e)
        {
            floor = 0;
            try
            {
                int floor_byte = Convert.ToInt32(((MonitoredItemNotification)e.NotificationValue).Value.WrappedValue.ToString());
                if(floor_byte != 0)
                {
                    while(floor_byte != 1)
                    {
                        floor_byte = floor_byte / 2;
                        floor++;
                    }
                    floor++;
                    (Controls[$"rb_floor{floor}"] as RadioButton).Invoke((MethodInvoker)delegate
                    {
                        (Controls[$"rb_floor{floor}"] as RadioButton).Checked = true;
                    });
                    myThread(430 - 40 * floor, pb_lift.Location.Y);
                }
                else
                {
                    for (int i = 1; i <= Convert.ToInt32(cnt_floor); i++)
                    {
                        (Controls[$"rb_floor{i}"] as RadioButton).Invoke((MethodInvoker)delegate
                        {
                            (Controls[$"rb_floor{i}"] as RadioButton).Checked = false;
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                ClientUtils.HandleException(this.Text, ex);
            }
        }
        //Проникновение в шахту или МП
        private void MonitoredItem30_Notification(MonitoredItem monitoredItem, MonitoredItemNotificationEventArgs e)
        {
            try
            {
                check = ((MonitoredItemNotification)e.NotificationValue).Value.ToString().Equals("True");
                this.pb_IntoHole.Invoke((MethodInvoker)delegate
                {

                    this.pb_IntoHole.Visible = check;
                });
            }
            catch (Exception ex)
            {
                ClientUtils.HandleException(this.Text, ex);
            }
        }
        //Зажата кнопка СТОП
        private void MonitoredItem31_Notification(MonitoredItem monitoredItem, MonitoredItemNotificationEventArgs e)
        {
            try
            {
                check = ((MonitoredItemNotification)e.NotificationValue).Value.ToString().Equals("True");
                this.pb_ClaimStop.Invoke((MethodInvoker)delegate
                {

                    this.pb_ClaimStop.Visible = check;
                });
            }
            catch (Exception ex)
            {
                ClientUtils.HandleException(this.Text, ex);
            }
        }
        //Кабина в открытом состоянии
        private void MonitoredItem32_Notification(MonitoredItem monitoredItem, MonitoredItemNotificationEventArgs e)
        {
            try
            {
                check = ((MonitoredItemNotification)e.NotificationValue).Value.ToString().Equals("True");
                this.pb_OpenDoor.Invoke((MethodInvoker)delegate
                {

                    this.pb_OpenDoor.Visible = check;
                });
            }
            catch (Exception ex)
            {
                ClientUtils.HandleException(this.Text, ex);
            }
        }
        //Отсутствует напряжение в цепи
        private void MonitoredItem33_Notification(MonitoredItem monitoredItem, MonitoredItemNotificationEventArgs e)
        {
            try
            {
                check = ((MonitoredItemNotification)e.NotificationValue).Value.ToString().Equals("True");
                this.pb_NoVoltage.Invoke((MethodInvoker)delegate
                {

                    this.pb_NoVoltage.Visible = check;
                });
            }
            catch (Exception ex)
            {
                ClientUtils.HandleException(this.Text, ex);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                this.connectServerCtrl1.ServerUrl = "opc.tcp://localhost:4841";
                string AppName = "LKDSOpcUA";
                //Настройка конфига
                ApplicationConfiguration config = new ApplicationConfiguration()
                {
                    ApplicationName = AppName,
                    ApplicationUri = Utils.Format(@"urn:{0}:" + AppName, System.Net.Dns.GetHostName()),
                    ApplicationType = ApplicationType.Client,
                    //Создание сертификата
                    SecurityConfiguration = new SecurityConfiguration
                    {
                        ApplicationCertificate = new CertificateIdentifier
                        {
                            StoreType = @"Directory",
                            StorePath = System.Windows.Forms.Application.StartupPath + @"\Cert\TrustedIssuer",
                            SubjectName = "CN=" + AppName + ", DC=" + System.Net.Dns.GetHostName()
                        },
                        TrustedIssuerCertificates = new CertificateTrustList
                        {
                            StoreType = @"Directory",
                            StorePath = System.Windows.Forms.Application.StartupPath + @"\Cert\TrustedIssuer"
                        },
                        TrustedPeerCertificates = new CertificateTrustList
                        {
                            StoreType = @"Directory",
                            StorePath = System.Windows.Forms.Application.StartupPath + @"\Cert\TrustedIssuer"
                        },
                        RejectedCertificateStore = new CertificateTrustList
                        {
                            StoreType = @"Directory",
                            StorePath = System.Windows.Forms.Application.StartupPath + @"\Cert\RejectedCertificates"
                        },
                        AutoAcceptUntrustedCertificates = true,
                        AddAppCertToTrustedStore = true,
                        RejectSHA1SignedCertificates = false//important
                    },
                    TransportConfigurations = new TransportConfigurationCollection(),
                    TransportQuotas = new TransportQuotas { OperationTimeout = 15000 },
                    ClientConfiguration = new ClientConfiguration { DefaultSessionTimeout = 60000 },
                    TraceConfiguration = new TraceConfiguration
                    {
                        DeleteOnLoad = true
                    },
                    DisableHiResClock = false
                };
                config.Validate(ApplicationType.Client).GetAwaiter().GetResult();
                if (config.SecurityConfiguration.AutoAcceptUntrustedCertificates)
                {
                    config.CertificateValidator.CertificateValidation += (s, ee) =>
                    { ee.Accept = (ee.Error.StatusCode == StatusCodes.BadCertificateUntrusted); };
                }

                this.connectServerCtrl1.Configuration = config;
                //this.connectServerCtrl1.UserIdentity = new UserIdentity("adm", "123456"); //Если есть логин и пароль
                this.connectServerCtrl1.UserIdentity = new UserIdentity();
                this.connectServerCtrl1.UseSecurity = true;

                var application = new ApplicationInstance
                {
                    ApplicationName = AppName,
                    ApplicationType = ApplicationType.Client,
                    ApplicationConfiguration = config
                };
            //Если установить маску трассировки 0=>остановить отображение журнала в окне вывода.
            Opc.Ua.Utils.SetTraceMask(0);//
            try
            {
                application.CheckApplicationInstanceCertificate(true, 2048).GetAwaiter().GetResult();//create certificate
            }
            catch { }
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)//Закрытие формы
        {
            Application.Exit();
        }

        void move(Object to)//Функция потока, передаем параметр
        {
            FromTo ft = (FromTo)to;
            try
            {
                if (ft.to > ft.from)
                {
                    for (int i = ft.to; i >= ft.from; i--)
                    {
                        this.pb_lift.Invoke((MethodInvoker)delegate
                        {
                            this.pb_lift.Location = new Point(pb_lift.Location.X, i);
                        });
                        Thread.Sleep(40);
                    }
                }
                else
                {
                    for (int i = ft.to; i <= ft.from; i++)
                    {
                        this.pb_lift.Invoke((MethodInvoker)delegate
                        {
                            this.pb_lift.Location = new Point(pb_lift.Location.X, i);
                        });
                        Thread.Sleep(40);
                    }
                }
            }
            catch { }
        }
        public void myThread(int from, int to) //Конструктор получает имя функции и номер до кторого ведется счет
        {
           Thread thread = new Thread(this.move);
           thread.Start(new FromTo(from, to));//передача параметра в поток
        }

        private void bnt_disconnect_Click(object sender, EventArgs e)//Отключение от сервера
        {
           
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
        private void PeopleInLift(string check, string status)//Наличие людей в лифте
        {
            if (check!=null)
            {
                _check = check;
            }
            if (status != null)
            {
                _status = status;
            }
            if (_check != null && _status != null)
            {
                //Если есть люди и двери закрыты
                if (_check.Equals("True") && _status.Equals("4"))
                {
                    pb_lift.Invoke((MethodInvoker)delegate
                    {
                        pb_lift.Image = Image.FromFile(@".\img\lift_people.jpg");
                    });
                }
                //Если нет людей и двери закрыты
                if (_check.Equals("False") && _status.Equals("4"))
                {
                    pb_lift.Invoke((MethodInvoker)delegate
                    {
                        pb_lift.Image = Image.FromFile(@".\img\lift_door_close.jpg");
                    });
                }
                //Если нет людей и двери открыты
                if (_check.Equals("False") && _status.Equals("2"))
                {
                    pb_lift.Invoke((MethodInvoker)delegate
                    {
                        pb_lift.Image = Image.FromFile(@".\img\lift_door_open.jpg");
                    });
                }
                //Если есть люди и двери открыты
                if (_check.Equals("True") && _status.Equals("2"))
                {
                    pb_lift.Invoke((MethodInvoker)delegate
                    {
                        pb_lift.Image = Image.FromFile(@".\img\people_door_open.PNG");
                    });
                }
            }
            else
            {
                //Если двери открыты
                if (_status.Equals("4"))
                {
                    pb_lift.Invoke((MethodInvoker)delegate
                    {
                        pb_lift.Image = Image.FromFile(@".\img\lift_door_close.jpg");
                    });
                }
                //Если двери закрыты
                if (_status.Equals("2"))
                {
                    pb_lift.Invoke((MethodInvoker)delegate
                    {
                        pb_lift.Image = Image.FromFile(@".\img\lift_door_open.jpg");
                    });
                }
            }
        }//Отображение лифта

      
    }

}
    class FromTo
    {
        public FromTo(int from, int to)
        {
            this.from = from;
            this.to = to;
        }

        public int from;
        public int to;
    }
   



