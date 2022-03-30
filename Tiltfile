SOURCE_IMAGE = os.getenv("SOURCE_IMAGE", default='dev.local/tanzu-dotnet-web-app-source')
LOCAL_PATH = os.getenv("LOCAL_PATH", default='.')
NAMESPACE = os.getenv("NAMESPACE", default='default')
NAME = "tanzu-dotnet-web-app"
RID = "ubuntu.18.04-x64"
CONFIGURATION = "Release"

local_resource(
  'live-update-build',
  cmd='dotnet publish src --configuration ' + CONFIGURATION + ' --runtime ' + RID + ' --self-contained false --output ./bin',
  deps=['./src'],
  ignore=['./src/bin', './src/obj'],
)

k8s_custom_deploy(
  NAME,
  apply_cmd="tanzu apps workload apply -f config/workload.yaml --live-update" +
            " --local-path " + LOCAL_PATH +
            " --source-image " + SOURCE_IMAGE +
            " --namespace " + NAMESPACE +
            " --yes >/dev/null" +
            " && kubectl get workload " + NAME + " --namespace " + NAMESPACE + " -o yaml",
  delete_cmd="tanzu apps workload delete " + NAME + " --namespace " + NAMESPACE + " --yes",
  deps=['./bin'],
  container_selector='workload',
  live_update=[
    sync('./bin', '/workspace')
  ]
)

k8s_resource(NAME, port_forwards=["8080:8080"],
            extra_pod_selectors=[{'serving.knative.dev/service': 'tanzu-dotnet-web-app'}])

allow_k8s_contexts('gke_pa-fbush_us-central1-a_tap-220128')