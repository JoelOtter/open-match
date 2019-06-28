// +build !e2ecluster

// Copyright 2019 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

package minimatch

import (
	"testing"

	"github.com/spf13/viper"
	"github.com/stretchr/testify/assert"
	"open-match.dev/open-match/internal/rpc"

	simple "open-match.dev/open-match/examples/evaluator/golang/simple/evaluate"
	rpcTesting "open-match.dev/open-match/internal/rpc/testing"
	harness "open-match.dev/open-match/pkg/harness/evaluator/golang"
)

// Create an evaluator service that will be used by the minimatch tests.
func createEvaluatorForTest(t *testing.T) *rpcTesting.TestContext {
	tc := rpcTesting.MustServeInsecure(t, func(p *rpc.ServerParams) {
		cfg := viper.New()
		assert.Nil(t, harness.BindService(p, cfg, simple.Evaluate))
	})

	return tc
}