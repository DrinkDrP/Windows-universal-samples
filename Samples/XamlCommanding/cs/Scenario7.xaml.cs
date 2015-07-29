//*********************************************************
//
// Copyright (c) Microsoft. All rights reserved.
// This code is licensed under the MIT License (MIT).
// THIS CODE IS PROVIDED *AS IS* WITHOUT WARRANTY OF
// ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING ANY
// IMPLIED WARRANTIES OF FITNESS FOR A PARTICULAR
// PURPOSE, MERCHANTABILITY, OR NON-INFRINGEMENT.
//
//*********************************************************

using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Commanding
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Scenario7 : Page
    {
        public Scenario7()
        {
            this.InitializeComponent();
        }

        private void CommandBar_Opening(object sender, object e)
        {
            this.appbarbutton.IsCompact = !this.appbarbutton.IsCompact;
        }

        private void CommandBar_Closed(object sender, object e)
        {
            this.appbarbutton.IsCompact = !this.appbarbutton.IsCompact;
        }
    }
}